using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Collections.Concurrent;
using Network;

namespace Client
{
    /*
     * Węzeł kliencki, wiadomości wpisuje użytkownik
     */
    public class Client
    {
        private int id;
        public int Id { get { return id; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        public Log Log; // logi zbierane z portów i od klienta

        private AAL AAL; // warstwa adaptacyjna 

        private PortsIn portsIn; //porty wejściowe
        public PortsIn PortsIn { get { return portsIn; } }

        private PortsOut portsOut; //porty wyjściowe
        public PortsOut PortsOut { get { return portsOut; } }

        public ConcurrentQueue<string> messages; // wiadomości odebrane
        private ConcurrentQueue<Cell> CellsQueue; // kolejka Cell

        /* Tworzy węzeł kliencki o danejkonfiguracji */
        public Client(Configuration.NetworkElement networkElement)
        {
            this.AAL = new AAL();
            this.id = networkElement.Info.ID;
            this.name = networkElement.Info.Name;
            this.Log = new Log();
            this.messages = new ConcurrentQueue<string>();

            Log.Queue.Enqueue(this.id.ToString());

            CellsQueue = new ConcurrentQueue<Cell>();

            List<Configuration.PortInput> inputPorts = networkElement.PortsIn;
            List<int> inputPortsIds = new List<int>();
            foreach (Configuration.PortInput port in inputPorts)
                inputPortsIds.Add(port.Id);
            portsIn = new PortsIn(Receive, this.Log, id, inputPortsIds);

            List<Configuration.PortOutput> outputPorts = networkElement.PortsOut;
            List<int> outputPortsIds = new List<int>();
            foreach (Configuration.PortOutput port in outputPorts)
                outputPortsIds.Add(port.Id);
            portsOut = new PortsOut(this.Log, id, outputPortsIds);

        }

        ~Client()
        {
        }

        public void StartWorking(string cloudHost, int cloudPort1, int cloudPort2)
        {
            IPEndPoint point1 = new IPEndPoint(IPAddress.Parse(cloudHost), cloudPort1);
            IPEndPoint point2 = new IPEndPoint(IPAddress.Parse(cloudHost), cloudPort2);

            portsOut.Connect(point1); // do chmury
            portsIn.Connect(point2); // z chmury
        }

        /* Skorzysta a AAL żeby podzielić wiadomość na komórki ATM, od zarzadcy dowie sie co i jak ma ustawic */
        public void Send(Data data, int port, int vpi, int vci)
        {
            InfoAAL info = new InfoAAL();
            info.data = data;
            info.node = id;
            info.port = port;
            info.VPI = vpi;
            info.VCI = vci;
            
            List<Cell> cells = AAL.dataToCells(info); // tworzymy komórki ATM do wysłania
            foreach (Cell cell in cells)
            {
                portsOut.sendDone.Reset();
                portsOut.Send(cell);
                portsOut.sendDone.WaitOne();
            }

        }

        /* Metoda odpowiedzialna za odbieranie danych na portach wejściowych */
        private void Receive(Cell Cell)
        {
            Log.Queue.Enqueue("Receive()");

            CellsQueue.Enqueue(Cell);
            
            if(Cell.PTI3) // jeżeli jest EOM
            {
                List<Cell> cells = new List<Cell>();

                Cell i = new Cell();
                while (!i.PTI3) // rób aż nie będzie to EOM
                {
                    i = new Cell();
                    CellsQueue.TryDequeue(out i);

                    cells.Add(i);
                }

                messages.Enqueue(new AAL().cellsToMessage(cells));
                cells.Clear();

            }

        }

    }


}
