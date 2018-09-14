using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network;

namespace Switch
{

    /*
     * Pole komutacyjne -> przetwarzanie komórki 
     * i nadanie na odpowiedni port wyjściowy na podstawie tablicy routingu
     */

    public class Matrix
    {
        private MappingTable mappingTable;
        public MappingTable MappingTable { get { return mappingTable; } set { mappingTable = value; } }

        private Switch switchElement;

        public Matrix(Switch switchElement, Configuration.NetworkElement networkElement)
        {
            this.switchElement = switchElement;

            mappingTable = new MappingTable();

            foreach (Configuration.RoutingEntry entry in networkElement.RoutingTable)
                mappingTable.Add(new HalfEntryMapping(entry.PortIn, entry.VpiIN, entry.VciIN), new HalfEntryMapping(entry.PortOut, entry.VpiOUT, entry.VciOUT));
        }

        /* Komutacja - nagłówek komórki jest wyjmowany i na podstawie wpisu z tablicy routingu komórka jest przekazywana na port wyj*/
        /* port wej ---> komutator ---> port wyjściowy */
        public void Commutation(Cell cell)
        {
            HalfEntryMapping source = new HalfEntryMapping(cell.portID, cell.VPI, cell.VCI);

            switchElement.Log.Queue.Enqueue("Matrix {src}: " + "port=" + cell.portID + " VPI=" + cell.VPI + " VCI=" + cell.VCI);
            if (mappingTable.ContainsKey(source))
            {
                HalfEntryMapping target = mappingTable[source]; // znalezienie w tablicy wezla docelowego

                /* Mapowanie VPI, VCI lub tylko VPI */
                cell.VPI = target.VPI;
                if (target.VCI > 0) cell.VCI = target.VCI;
                cell.portID = target.Port;

                /* informacja o danych na wyjście */
                switchElement.Log.Queue.Enqueue("Matrix {dest}: " + "port=" + cell.portID + " VPI=" + cell.VPI + " VCI=" + cell.VCI);

                switchElement.PortsOut.sendDone.Reset();
                switchElement.PortsOut.Send(cell); // wysłanie komórki na dany port
                switchElement.PortsOut.sendDone.WaitOne();

                switchElement.Log.Queue.Enqueue("Commutate to (port=" + cell.portID + ", VPI= " + cell.VPI + " VCI=" + cell.VCI + "): " + Encoding.UTF8.GetString(cell.Data));
            }
        }



    }

}