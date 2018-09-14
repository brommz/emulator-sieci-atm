using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientCommunicationWindow : Form
    {
        private Client Client;
        private int port;

        public ClientCommunicationWindow(int port, Client client)
        {
            this.port = port;
            this.Client = client;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientCommunicationWindow_Load(object sender, EventArgs e)
        {
            outPortBox.Text = this.port.ToString();
        }

        private void receivedRefreshButton_Click(object sender, EventArgs e)
        {
            while (!Client.messages.IsEmpty)
            {
                string message = "";
                Client.messages.TryDequeue(out message);
                receivedMessagesBox.Text += message + Environment.NewLine + Environment.NewLine;
            }
        }

        private void sendOnceButton_Click(object sender, EventArgs e)
        {
            int vpi = Convert.ToInt32(VPIBox.Text.ToString());
            int vci = Convert.ToInt32(VCIBox.Text.ToString());
            Client.Send(new Network.Data(messageBox.Text.ToString()), port, vpi, vci);
        }
    }
}
