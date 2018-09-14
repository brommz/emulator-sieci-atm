using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configuration;
using Network;
using System.Collections.Concurrent;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Cell cell = new Cell();
            cell.nodeID = 1;
            cell.portID = 51;
            cell.Data = Encoding.UTF8.GetBytes("TESST");
            Console.WriteLine("My LEN: " + cell.ToByte().Length);


            Cell cell2 = new Cell();
            cell2.MakeCell(cell.ToByte());

            Console.WriteLine(Encoding.UTF8.GetString(cell2.Data));

        /*    Console.WriteLine("Client <---> Cloud");

            AAL aal = new AAL();

            InfoAAL info = new InfoAAL();
            info.node = 81;
            info.port = 666;
            info.VPI = 100;
            info.VCI = 500;
            info.data = new Data("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa#bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb#ccccccccccccccccccccccccccccccccccccccccccccccc#123456789#");

            List<Cell> cells = aal.dataToCells(info); // nasza wiadomość na komórki

            foreach (Cell cell in cells)
                Program.
                    ToPortsOut(cell);
   */
            //Console.WriteLine(Encoding.UTF8.GetString(cells[0].Data) + " node=" + cells[0].nodeID + " port=" + cells[0].portID + " VPI=" + cells[0].VPI + " VCI=" + cells[0].VCI);


            Console.ReadKey();
           
        }
        /*
        public static void SendToPortsOut(Cell cell) // klient wysyła (PortOut dostaje Cell i wysyła byte[])
        {
            SendToCloud(cell.ToByte());
        }

        public static void SendToCloud(byte[] bytes)
        {
            Cell ncell = new Cell();
            ncell.MakeCell(bytes);
            Console.WriteLine("Cloud recv: port=" + ncell.portID + ", Data="+ Encoding.UTF8.GetString(ncell.Data));
            Console.WriteLine(bytes.Length);
            Console.WriteLine("");

            Receive(ncell);
        }

        public static ConcurrentQueue<Cell> cells = new ConcurrentQueue<Cell>();

        private static void Receive(Cell Cell) // klient sobie odbiera i ma zrobić wiadomość 
        {
            cells.Enqueue(Cell);

            if (Cell.PTI3) // jeżeli jest EOM
            {
                List<Cell> cellsList = new List<Cell>();

                Cell i = new Cell();
                while (!i.PTI3) // rób aż nie będzie to EOM
                {
                    i = new Cell();
                    cells.TryDequeue(out i);

                    cellsList.Add(i);
                }

                Console.WriteLine("MESSAGE: " + new AAL().cellsToMessage(cellsList));
                cellsList.Clear();
            }

        }*/

    }
}
