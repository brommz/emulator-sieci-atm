using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Collections.Concurrent;
using Configuration;
using Network;
using System.Threading;

namespace Cloud
{
    /* Klasa odpowiedzialna za wysyłanie do węzłów */
    public class Output
    {
        /* Słownik info o węzłach podłączonych - kluczem jest id węzła */
        private Dictionary<int, Socket> nodes;

        private Socket serverSocket; // gniazdo serwera

        private byte[] firstBytesData = new byte[StaticInfo.CBUFFER]; // bufor danych wejściowych

        private Log myLog; // logi z działalności

        public ManualResetEvent sendDone = new ManualResetEvent(false);

        public Output(Network.Log log, int port)
        {
            this.myLog = log;
            nodes = new Dictionary<int, Socket>();
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, port);

                serverSocket.Bind(ipEndPoint);
                serverSocket.Listen(StaticInfo.MAXNODES);
                serverSocket.BeginAccept(new AsyncCallback(OnAccept), null);

                myLog.Queue.Enqueue("Output is working = " + port);
            }
            catch (Exception) { }
        }

        ~Output()
        {
            for (int i = 0; i < nodes.Count; i++)
                nodes.ElementAt(i).Value.Close();
        }

        private void OnAccept(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = serverSocket.EndAccept(ar);
                serverSocket.BeginAccept(new AsyncCallback(OnAccept), null); // Nasłuchuj na nowych klientów

                clientSocket.BeginReceive(firstBytesData, 0, firstBytesData.Length, SocketFlags.None, new AsyncCallback(FirstReceive), clientSocket);
            }
            catch (Exception) { }
        }

        /* Wysyłanie */
        public void Send(Cell cell)
        {
            if (nodes.ContainsKey(cell.nodeID))
            {
                myLog.Queue.Enqueue("Send( bytesLen:" + cell.ToByte().Length + ") to node= " + cell.nodeID + " , data= " + Encoding.UTF8.GetString(cell.Data));
                sendDone.Reset();
                Socket nodeSocket = nodes[cell.nodeID]; //Wyślij na węzeł o numerze węzła docelowego
                nodeSocket.BeginSend(cell.ToByte(), 0, cell.ToByte().Length, SocketFlags.None, new AsyncCallback(OnSend), nodeSocket);
                sendDone.WaitOne();

            }
        }

        private void OnSend(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;
                client.EndSend(ar);

                sendDone.Set();

                myLog.Queue.Enqueue("End Send msg");
            }
            catch (Exception) { }
        }

        /* Służy do odebrania tylko tej wiadomości informujacej o ID węzła */
        private void FirstReceive(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = (Socket)ar.AsyncState;
                clientSocket.EndReceive(ar);
                myLog.Queue.Enqueue("(Output) New client connected, ID = " + BitConverter.ToInt32(firstBytesData, 0).ToString());

                int nodeId = BitConverter.ToInt32(firstBytesData, 0);
                if (nodes.ContainsKey(nodeId)) nodes.Remove(nodeId);
                nodes.Add(nodeId, clientSocket);

                /*Cell cell = new Cell();
                cell.nodeID = nodeId;
                cell.portID = 51;
                cell.Data = Encoding.UTF8.GetBytes("TSST");
                myLog.Queue.Enqueue("My LEN: " + cell.ToByte().Length);
                Send(cell);*/
            }
            catch (Exception) { }
        }

    }
}
