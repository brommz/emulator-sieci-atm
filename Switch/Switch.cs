using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using Network;

namespace Switch
{
    /*
     * ATM Switch
     */
    public class Switch
    {
        private int id;
        public int Id { get { return id; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        public Log Log; // logi zbierane z portów od switcha

        private PortsIn portsIn; //porty wejściowe switcha
        public PortsIn PortsIn { get { return portsIn; } }

        private PortsOut portsOut; //porty wyjściowe switcha
        public PortsOut PortsOut { get { return portsOut; } }

        private Matrix matrix; // pole komutacyjne
        public Matrix Matrix { get { return matrix; } }

        public Switch(Configuration.NetworkElement networkElement)
        {
            id = networkElement.Info.ID;
            name = networkElement.Info.Name;
            Log = new Log();

            matrix = new Matrix(this, networkElement);

            List<Configuration.PortInput> inputPorts = networkElement.PortsIn;
            List<int> inputPortsIds = new List<int>();
            foreach (Configuration.PortInput port in inputPorts)
                inputPortsIds.Add(port.Id);
            portsIn = new PortsIn(Commutation, Log, id, inputPortsIds);

            List<Configuration.PortOutput> outputPorts = networkElement.PortsOut;
            List<int> outputPortsIds = new List<int>();
            foreach (Configuration.PortOutput port in outputPorts)
                outputPortsIds.Add(port.Id);
            portsOut = new PortsOut(Log, id, outputPortsIds);

            
        }

        ~Switch()
        {
        }

        public void StartWorking(string cloudHost, int cloudPort1, int cloudPort2)
        {
            IPEndPoint point1 = new IPEndPoint(IPAddress.Parse(cloudHost), cloudPort1);
            IPEndPoint point2 = new IPEndPoint(IPAddress.Parse(cloudHost), cloudPort2);

            portsOut.Connect(point1);
            portsIn.Connect(point2);
            
        }

        /* Działanie komutatora */
        private void Commutation(Cell cell)
        {
            Log.Queue.Enqueue("Commutation()");
            Matrix.Commutation(cell);
        }

    }
}
