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
using Network;
using System.IO;

namespace Cloud
{

    /* Klasa odpowiedzialna za odbieranie od węzłów */
    public class Input
    {
        /* Słownik info o węzłach podłączonych - kluczem jest id węzła */
        private Dictionary<int, Socket> nodes;

        private Socket serverSocket; // gniazdo serwera

        private byte[] firstBytesData = new byte[StaticInfo.CBUFFER]; // bufor danych wejściowych

        private Log Log; // logi z działalności

        public delegate void MakeOnReceive(Cell tcpCell); // wywołuje metodę w kliencie/switchu i przekazyje tcpCell
        public MakeOnReceive makeOnReceive;

        private ManualResetEvent receiveDone = new ManualResetEvent(false);

        public Input(MakeOnReceive makeOnReceive, Network.Log log, int port)
        {
            this.makeOnReceive = makeOnReceive;
            this.Log = log;
            nodes = new Dictionary<int, Socket>();

            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, port);

                serverSocket.Bind(ipEndPoint);
                serverSocket.Listen(StaticInfo.MAXNODES);
                serverSocket.BeginAccept(new AsyncCallback(OnAccept), serverSocket);

                Log.Queue.Enqueue("Input is working, port = " + port);
            }
            catch (Exception) { }
        }

        ~Input()
        {
            for (int i = 0; i < nodes.Count; i++)
                nodes.ElementAt(i).Value.Close();
        }

        private void OnAccept(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = serverSocket.EndAccept(ar);
                serverSocket.BeginAccept(new AsyncCallback(OnAccept), serverSocket); // Nasłuchuj na innych klientów
                
                // klienta uznajemy za połączonego, gdy się przedstawi swoim ID
                clientSocket.BeginReceive(firstBytesData, 0, StaticInfo.CBUFFER, SocketFlags.None, new AsyncCallback(FirstReceive), clientSocket);
            }
            catch (Exception) { }
        }

        /* Służy do odebrania tylko tej wiadomości informujacej o ID węzła */
        private void FirstReceive(IAsyncResult ar)
        {
            Log.Queue.Enqueue("FirstReceive()");
            try
            {
                Socket clientSocket = (Socket)ar.AsyncState;
                clientSocket.EndReceive(ar);

                /* dodaje nowy węzeł jako nowy clientSocket */
                Log.Queue.Enqueue("(Input) New client connected, ID = " + BitConverter.ToInt32(firstBytesData, 0).ToString());

                int nodeId = BitConverter.ToInt32(firstBytesData, 0);
                if (nodes.ContainsKey(nodeId)) nodes.Remove(nodeId);
                    nodes.Add(nodeId, clientSocket);

                ClientInfo clientInfo = new ClientInfo(clientSocket); // każdy klient ma swoje ClientInfo do odbioru

                /* Dalej odbiera już normalnie funkcją OnReceive */
                clientSocket.BeginReceive(clientInfo.buffer, 0, clientInfo.buffer.Length, SocketFlags.None, new AsyncCallback(OnReceive), clientInfo);
            }
            catch (Exception) { Log.Queue.Enqueue("error FirstReceive"); }
            
            Log.Queue.Enqueue("End FirstReceive()");
        }

        private void OnReceive(IAsyncResult ar)
        {
            Log.Queue.Enqueue("OnReceive()");
            try
            {
                ClientInfo clientInfo = (ClientInfo)ar.AsyncState;
                Socket clientSocket = clientInfo.socket;

                int bytesRead = clientSocket.EndReceive(ar);
                clientInfo.count += bytesRead;

                if (bytesRead > 0) // There might be more data 
                {
                    clientInfo.sb.Write(clientInfo.buffer, 0, bytesRead);

                    int Length = Convert.ToInt32(clientInfo.sb.Length);

                    Log.Queue.Enqueue("KURWAAAA");

                    if (clientInfo.count == 65) // jeżeli bufor odebranych jest równy rozmiarowi komórki (65 bajtów)
                    {
                        Cell recvCell = new Cell();
                        recvCell.MakeCell(clientInfo.sb.ToArray());

                        Log.Queue.Enqueue("Data received from ID = " + nodes.FirstOrDefault(node => node.Value == clientSocket).Key.ToString() + " msg: " + Encoding.UTF8.GetString(recvCell.Data));

                        clientInfo.count = 0;
                        clientInfo.sb = new MemoryStream();

                        makeOnReceive(recvCell);
                        clientSocket.BeginReceive(clientInfo.buffer, 0, StaticInfo.CBUFFER, 0, new AsyncCallback(OnReceive), clientInfo);
                    }
                    else // Not all data received. Get more
                    {
                        Log.Queue.Enqueue("AAAAAAA");
                        clientSocket.BeginReceive(clientInfo.buffer, 0, StaticInfo.CBUFFER, 0, new AsyncCallback(OnReceive), clientInfo);
                    }
                }
                else // TODO: Tutaj może być jakiś problem
                {
                    Log.Queue.Enqueue("ZZZZZ");
                    clientSocket.BeginReceive(clientInfo.buffer, 0, StaticInfo.CBUFFER, 0, new AsyncCallback(OnReceive), clientInfo);
                }
                
            }
            catch (Exception ex ) { Log.Queue.Enqueue("error OnReceive()"); }
            Log.Queue.Enqueue("End OnReceive()");
        }

        public class ClientInfo
        {
            public Socket socket;
            public byte[] buffer; // bufor danych wejściowych
            public MemoryStream sb; // tutaj wrzucamy i z tego tworzymy odebraną komórkęs
            public int count;

            public ClientInfo()
            {
                socket = null;
                buffer = new byte[StaticInfo.CBUFFER];
                sb = new MemoryStream();
                count = 0;
            }

            public ClientInfo(Socket socket)
            {
                this.socket = socket;
                buffer = new byte[StaticInfo.CBUFFER];
                sb = new MemoryStream();
                count = 0;
            }
        }


    }

}
