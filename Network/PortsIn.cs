using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Configuration;
using System.Collections.Concurrent;
using System.IO;

namespace Network
{
    /* Odpowiada za odbieranie danych z połączenia z chmurą */
    public class PortsIn
    {
        private int nodeNumber; // numer wezla, do ktorego to nalezy

        private Socket cloudSocket; // gniazdo, z którym jest połączony węzeł

        private Port[] ports; // wirtualne porty ATM wejściowe

        private byte[] byteData = new byte[StaticInfo.CBUFFER]; // bufor danych odbieranych z Socketa
   
        private Log myLog; // tutaj dodaje wszystkie logi

        public delegate void MakeOnReceive(Cell cell); // wywołuje metodę w kliencie/switchu i przekazyje tcpCell
        public MakeOnReceive makeOnReceive;

        private ManualResetEvent receiveDone = new ManualResetEvent(false);

        private MemoryStream buffer = new MemoryStream();

        public PortsIn(MakeOnReceive makeOnReceive, Log log, int nodeNumber, List<int> portIDs)  
        {
            this.makeOnReceive = makeOnReceive;
            this.myLog = log;
            this.nodeNumber = nodeNumber;

            ports = new Port[portIDs.Count];
            for (int i = 0; i < ports.Length; i++)
                ports[i] = new Port(portIDs.ElementAt(i));

            myLog.Queue.Enqueue("PortsIn is working");
        }

        ~PortsIn()
        {
            if (cloudSocket != null) cloudSocket.Close();
        }

        /* Połącz z chmurą */
        public void Connect(IPEndPoint cloud)
        {
            try
            {
                cloudSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                cloudSocket.BeginConnect(cloud, new AsyncCallback(OnConnect), cloudSocket);

                if (cloudSocket.Connected)
                {
                    foreach (Port port in ports) // ustaw porty jako połączone i otwarte
                        port.Connected = true;
                }
            }
                
            catch (Exception e) { myLog.Queue.Enqueue("Connect() / Receiver()" + e.ToString()); }
        }

        private void OnConnect(IAsyncResult ar)
        {
            try
            {
                cloudSocket.EndConnect(ar);
                myLog.Queue.Enqueue("Connected to cloud, ID=" + nodeNumber);

                /* przedstaw się chmurze*/
                cloudSocket.BeginSend(BitConverter.GetBytes(nodeNumber), 0, BitConverter.GetBytes(nodeNumber).Length, SocketFlags.None, new AsyncCallback(Present), cloudSocket);
            }
            catch (Exception e) { myLog.Queue.Enqueue("OnConnect() error: " + e.ToString());  }
        }

        /* Przedstawiamy się chmurze, którym jesteśmy węzłem */
        private void Present(IAsyncResult ar)
        {
            try
            {
                int bytesSent = cloudSocket.EndSend(ar);  // Complete sending the data to the remote device.
                myLog.Queue.Enqueue("Presenting PortsIn finished");

                Receive();
            }
            catch (Exception e) { myLog.Queue.Enqueue("Present error:" + e.ToString()); }
        }


        private void Receive()
        {
            try
            {
                myLog.Queue.Enqueue("Receive(!)");

                receiveDone.Reset();
                cloudSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnReceive), cloudSocket);
                
                receiveDone.WaitOne();
                Receive();
            }
            catch (Exception e) { myLog.Queue.Enqueue("Receive() error"); }
        }

        /* metoda callback do odbioru danych */
        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                myLog.Queue.Enqueue("OnReceive(!)");
                int bytesRead = cloudSocket.EndReceive(ar);

                if (bytesRead > 0) // There might be more data
                {
                    buffer.Write(byteData, 0, bytesRead);
                    if (bytesRead == 65)
                    {
                        Cell recvCell = new Cell();
                        recvCell.MakeCell(buffer.ToArray()); // BLAD

                        makeOnReceive(recvCell);

                        myLog.Queue.Enqueue("Recv from: (port=" + recvCell.portID.ToString() + "): " + Encoding.UTF8.GetString(recvCell.Data));
                        receiveDone.Set();
                        buffer = new MemoryStream();
                    }
                    else
                    {
                        myLog.Queue.Enqueue("Not all data, bytesRead: " + bytesRead);
                        cloudSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnReceive), cloudSocket);
                    }
                }
                else
                    receiveDone.Set();

            }
            catch (Exception e) { myLog.Queue.Enqueue("OnReceive error: " + e.ToString());  }

            myLog.Queue.Enqueue("!!!!!!!!!!!!!!!");
        }

        class Port
        {
            public int PortId;

            /* info, czy jest polaczony z chmura */
            public bool Connected;

            public Port(int id)
            {
                PortId = id;
                Connected = false;
            }
        }
    }
}
