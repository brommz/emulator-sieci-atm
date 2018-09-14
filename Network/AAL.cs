using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /*
     * Adaptowanie wiadomości do wielu komórek ATM
     */
    // TODO: naprawić to!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    public class AAL
    {
        public List<Cell> dataToCells(InfoAAL info)
        {
            List<Cell> result = new List<Cell>();
            List<byte[]> portions = info.data.getPortions();

            for (int i = 0; i < portions.Count; i++)
            {
                Cell cell = new Cell();
                cell.Data = portions.ElementAt(i);
                cell.VPI = info.VPI;
                cell.VCI = info.VCI;
                cell.nodeID = info.node;
                cell.portID = info.port;

                if (i == portions.Count - 1)
                    cell.PTI3 = true;

                result.Add(cell);
            }
            return result;
        }
         
        /* Adaptacja z wielu komorek 48B na wiadomosc */
        public string cellsToMessage(List<Cell> cells)
        {
            byte[] array = new byte[cells.Count * 48];

            for (int i = 0; i < cells.Count; i++)
            {
                Buffer.BlockCopy(cells.ElementAt(i).Data, 0, array, i * 48, 48);
            }

            return Encoding.UTF8.GetString(array);
        }

        public AAL()
        {
        }
    }

    public struct InfoAAL
    {
        public int VPI;
        public int VCI;
        public Data data;
        public int node;
        public int port;
    }
}
