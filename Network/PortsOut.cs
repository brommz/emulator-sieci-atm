using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Network
{
    /* Odpowiada za wysyłanie komórek do chmury */
    public class PortsOut
    {
        private int nodeNumber; // numer wezla, do ktorego to nalezy

        private Socket cloudSocket; // gniazdo, z którym jest połączony węzeł

        private Port[] ports; // wirtualne porty ATM

        private Log myLog; // tutaj dodaje wszystkie logi

        public ManualResetEvent sendDone = new ManualResetEvent(false);

        public PortsOut(Log log, int nodeNumber, List<int> portIDs)  
        {
            this.myLog = log;
            this.nodeNumber = nodeNumber;
            ports = new Port[portIDs.Count];
            for (int i = 0; i < ports.Length; i++)
                ports[i] = new Port(portIDs.ElementAt(i));
            myLog.Queue.Enqueue("PortsOut is working");
        }

        /* Połącz z chmurą */
        public void Connect(IPEndPoint cloud)
        {
            myLog.Queue.Enqueue("Connect()");
            try
            {
                cloudSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                cloudSocket.BeginConnect(cloud, new AsyncCallback(OnConnect), cloudSocket);
            }
            catch (Exception e) { myLog.Queue.Enqueue("Connection problem"); }
        }

        private void OnConnect(IAsyncResult ar)
        {
            myLog.Queue.Enqueue("OnConnect()");
            try
            {
                cloudSocket.EndConnect(ar);

                foreach (Port port in ports) // ustaw porty jako połączone
                    port.Connected = true;
                
                myLog.Queue.Enqueue("Connected to cloud, ID=" + nodeNumber);

                /* przedstaw się chmurze, którym węzłem jesteś*/
                cloudSocket.BeginSend(BitConverter.GetBytes(nodeNumber), 0, BitConverter.GetBytes(nodeNumber).Length, SocketFlags.None, new AsyncCallback(Present), cloudSocket);
            }
            catch (Exception e) { myLog.Queue.Enqueue("Connection problem"); }
        }

        /* Przedstawiamy się chmurze, którym jesteśmy węzłem */
        private void Present(IAsyncResult ar)
        {
            myLog.Queue.Enqueue("Present()");
            try
            {
                cloudSocket.EndSend(ar);  // Complete sending the data to the remote device.
                myLog.Queue.Enqueue("Presenting PortsOut finished");
            }
            catch (Exception e) { myLog.Queue.Enqueue("Present error: " + e.ToString()); }

            myLog.Queue.Enqueue("End Present()");
        }

        /* Wyślij z portu wyjściowego ATM daną komórkę*/
        public void Send(Cell cell) 
        {
            myLog.Queue.Enqueue("Send()");

            Cell newCell = cell;
            newCell.portID = cell.portID; // port ATM, który ma zostać wykorzystany jako wyjściowy
            newCell.nodeID = nodeNumber;

            byte[] cellBytes = newCell.ToByte(); // komórka ATM zapisana bajtowo 

            bool portConnected = false;
            foreach (Port Port in ports)
                if (Port.PortID == newCell.portID) portConnected = Port.Connected;

            if (portConnected)
            {
                try 
                {
                    myLog.Queue.Enqueue("Sending started: " + Encoding.UTF8.GetString(cell.Data));
                    cloudSocket.BeginSend(cellBytes, 0, cellBytes.Length, SocketFlags.None, new AsyncCallback(OnSend), cloudSocket);
                }
                catch (SocketException) 
                {
                    Console.Error.WriteLine("Send problem");
                }
            }
        }

        private void OnSend(IAsyncResult ar)
        {
            try
            {
                int bytesSent = cloudSocket.EndSend(ar);  // Complete sending the data to the remote device.
                myLog.Queue.Enqueue("Sending finished");

                sendDone.Set();
            }
            catch (Exception e) { myLog.Queue.Enqueue("Send error: " + e.ToString());  }
        }

        class Port
        {
            public int PortID;
           
            /* info, czy jest polaczony z chmura */

            public bool Connected;

            public Port(int id)
            {
                PortID = id;
                Connected = true;
            }
        }
    }
}
