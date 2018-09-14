using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Network;

namespace Client
{


    // Okno klienta (ClientWindow) tworzone jako formularz systemu Windows (Form)
    public partial class ClientWindow : Form
    {
        private Client Client; // obiekt odpowiedzialny za logikę switcha

        private string xmlPathNetwork = "topologia.xml"; // ścieżka do pliku konfiguracyjnego sieci
        private string xmlPathNode; // ścieżka do pliku konfiguracyjnego węzła

        private Configuration.NetworkElement networkElement;
        private Configuration.Network network;


        #region Konstruktor

        // Konstruktor okna klienta
        public ClientWindow()
        {
            InitializeComponent();  // Inicjalizacja okna klienta
        }

        ~ClientWindow()
        {
        }

        public ClientWindow(string xmlPathNode)
        {
            this.xmlPathNode = xmlPathNode;
            InitializeComponent();  // Inicjalizacja okna chmury
        }

        #endregion


        #region Składowe

        #endregion


        #region Zdarzenia interfejsu


        // Naciśnięcie przycisku "Dołącz do sieci"
        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                string dirPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location); 
                networkElement = Configuration.NetworkElement.deserialize(dirPath + "\\" + xmlPathNode);
                network = Configuration.Network.deserialize(dirPath + "\\" + xmlPathNetwork);

                //Client = new Client(networkElement);
                Client.StartWorking(network.Info.CloudHost, network.Info.CloudPort1, network.Info.CloudPort2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia: " + ex.Message, "Node", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion


        #region Metody

        #endregion


        #region Klasy pomocnicze i inne przydatne rzeczy

        #endregion


        #region Kod wygenerowany przez Visual Studio 2013

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) 
        {
            
            try
            {
                new ClientCommunicationWindow(Convert.ToInt32(outPortComboBox.Text.ToString()), Client).Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Problem");
            }
            
        }


        #endregion

        private void ClientWindow_Load(object sender, EventArgs e)
        {
            try
            {
                string dirPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                networkElement = Configuration.NetworkElement.deserialize(dirPath + "\\" + xmlPathNode);
                network = Configuration.Network.deserialize(dirPath + "\\" + xmlPathNetwork);

                clientNameBox.Text = networkElement.Info.Name;
                cloudIPBox.Text = network.Info.CloudHost;
                cloudPort1Box.Text = network.Info.CloudPort1.ToString();
                cloudPort2Box.Text = network.Info.CloudPort2.ToString();

                for (int i = 0; i < networkElement.PortsOut.Count; i++)
                    outPortComboBox.Items.Add(networkElement.PortsOut.ElementAt(i).Id);

                Client = new Client(networkElement);
            }
            catch (Exception) { }
        }

        private void logRefreshButton_Click(object sender, EventArgs e)
        {
            while (!Client.Log.Queue.IsEmpty)
            {
                string log = "";
                Client.Log.Queue.TryDequeue(out log);
                logTextBox.Text += log + Environment.NewLine + Environment.NewLine;
            }
        }

        private void ClientWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void ClientWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

    }
}
