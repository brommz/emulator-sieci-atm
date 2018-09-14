using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network;

namespace Cloud
{
    /* Pole komutacyjne chmury */
    public class Matrix
    {
        private ForwardingTable fTable = new ForwardingTable(); // tablica kierowania z węzła do węzła
        public ForwardingTable ForwardingTable { get { return fTable; } set { fTable = value; } }

        private Cloud cloud; // odwołanie do obiektu chmury, żeby móc wysyłać

        public Matrix(Cloud cloud, Configuration.Network network)
        {
            this.cloud = cloud;
            int id = 0;
            foreach (Configuration.Link entry in network.Links)
                fTable.Add(new HalfEntryForwarding(entry.Source.Id, entry.Source.PortId), new HalfEntryForwarding(entry.Destination.Id, entry.Destination.PortId), id++);
        }

        /* komutacja, wejście to dane węzła źródłowego */
        public void Commutation(Cell cell)
        {
            cloud.Log.Queue.Enqueue("COMMUTATION (entry): " + cell.nodeID + " " + cell.portID);
            HalfEntryForwarding source = new HalfEntryForwarding(cell.nodeID, cell.portID);
            
            cloud.Log.Queue.Enqueue("Matrix {src}: " + "node=" + cell.nodeID + " port=" + cell.portID);

            if (fTable.ContainsKey(source))
            {
                HalfEntryForwarding target = fTable[source]; // znalezienie węzła docelowego w tablicy
                
             
                cell.nodeID = target.ID;
                cell.portID = target.Port;

                /* informacja o danych na wyjście */
                cloud.Log.Queue.Enqueue("Matrix {dest}: " + "node=" + cell.nodeID + " port=" + cell.portID);

                cloud.output.Send(cell);

                cloud.Log.Queue.Enqueue("Commutate to (node=" + cell.nodeID + " port=" + cell.portID + " VPI= " + cell.VPI + " VCI=" + cell.VCI + "): " + Encoding.UTF8.GetString(cell.Data));
            }
        }
    }
}
