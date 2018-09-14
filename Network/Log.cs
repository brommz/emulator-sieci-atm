using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Network
{
    /* Struktura przechowująca Log systemu */
    public class Log
    {
        public ConcurrentQueue<string> Queue; // kolejka logów
        public Log()
        {
            Queue = new ConcurrentQueue<string>();
        }
    }
}
