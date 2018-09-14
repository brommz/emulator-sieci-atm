using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /*
     * Reprezentuje komórkę ATM (oraz  nad nią)
     */
    public class Cell
    {
        private int vpi;
        public int VPI { get { return vpi; } set { vpi = value; } }

        private int vci;
        public int VCI { get { return vci; } set { vci = value; } }

        public byte[] data = new byte[48]; // nasze 48 B danych
        public byte[] Data 
        { 
            get { return data; }
            set 
            {
                byte[] myValue = value;
                for (int i = 0; i < myValue.Length; i++)
                    data[i] = myValue[i]; // BLAD
            }
        }


        public bool PTI3; // PTI-> bit 3 (End of Message)

        /* Część potrzebna do  */
        public int nodeID; // id wezla (do chmury = z ktorego wezla ATM idzie, do chmury = do ktorego wezla ATM idzie)
       
        public int portID; // port ATM (do chmury = z ktorego portu ATM idzie, od chmury = do ktorego portu ATM wezla docelowego)

        public Cell()
        {
            vpi = 0;
            vci = -1;
            data = new byte[48];
            for (int i = 0; i < data.Length; i++)
                data[i] = Convert.ToByte('`');

            PTI3 = false;
            nodeID = 0;
            portID = 0;
        }

        /* Konwersja Cell w ciąg bajtów */
        public byte[] ToByte()
        {
            List<byte> result = new List<byte>();

            result.AddRange(BitConverter.GetBytes(PTI3)); // długość 1B
            result.AddRange(BitConverter.GetBytes(nodeID)); // długość 4B
            result.AddRange(BitConverter.GetBytes(portID)); // długość 4B

            result.AddRange(BitConverter.GetBytes(VPI)); // długość 4B
            result.AddRange(BitConverter.GetBytes(VCI)); // długość 4B

            result.AddRange(Data); // 48B

            return result.ToArray();
        }

        /* Ustwienie Cell z ciągu bajtów */
        public void MakeCell(byte[] byteData) // ciąg bajtów == komórka TCP (ATM)
        {
            int index = 0; // start index
            this.PTI3 = BitConverter.ToBoolean(byteData, index); index++;
            this.nodeID = BitConverter.ToInt32(byteData, index); index += 4;
            this.portID = BitConverter.ToInt32(byteData, index); index += 4;

            this.VPI = BitConverter.ToInt32(byteData, index); index += 4;
            this.VCI = BitConverter.ToInt32(byteData, index); index += 4;

            List<byte> temp = new List<byte>();
            for (int i = index; i < byteData.Length; i++)
                temp.Add(byteData[i]);

            this.Data = temp.ToArray(); // BLAD
            
            /* Do tworzenia komórki ten znak ~ jest niepotrzebny!!! */
        }
    }
}
