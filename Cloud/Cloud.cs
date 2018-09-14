using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Network;

namespace Cloud
{
    /* Klasa odpowiedzialna za działanie chmury */
    public class Cloud
    {
        private int portIn; // nr portu  wejściowego

        private int portOut; //nr portu  wejściowego

        private Input input; // wejścia chmury

        public Output output; // wyjścia chmury

        public Matrix matrix; // komutator chmury

        public Log Log; // logi

        public Cloud(Configuration.Network network)
        {
            portIn = network.Info.CloudPort1;
            portOut = network.Info.CloudPort2;

            Log = new Log();

            matrix = new Matrix(this, network);
        }

        public void StartWorking()
        {
            input = new Input(matrix.Commutation, Log, portIn);
            output = new Output(Log, portOut);
        }
    }
}
