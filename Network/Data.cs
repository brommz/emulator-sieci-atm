using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.IO;

namespace Network
{
    /*
     * Wiadomoœæ klienta
     */

    public class Data
    {

        public string data; // wiadomoœæ klienta
        private byte[] bytes; // wiadomoœæ w bajtach

        public Data(string message)
        {
            data = message;
            bytes = System.Text.Encoding.UTF8.GetBytes(data);
        }

        /* Zwraca listê kolejnych 48B */
        public List<byte[]> getPortions()
        {
            byte[] source = this.bytes;
            List<byte[]> result = new List<byte[]>();

            for (int i = 0; i < source.Length; i += 48)
            {
                Console.WriteLine(i);
                byte[] buffer = new byte[48];

                if (source.Length - i >= 48)
                {
                    Buffer.BlockCopy(source, i, buffer, 0, 48);
                    result.Add(buffer);
                }
                else
                {
                    Buffer.BlockCopy(source, i, buffer, 0, source.Length - i);
                    result.Add(buffer);
                }
            }
            return result;
        }
    }

}