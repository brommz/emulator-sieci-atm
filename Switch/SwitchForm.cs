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

namespace Switch
{


    //Okno węzła sieciowego (NodeWindow) tworzone jako formularz systemu Windows (Form)
    public partial class SwitchWindow : Form
    {
        private Switch Switch; // obiekt odpowiedzialny za logikę switcha

        private string xmlPathNetwork = "topologia.xml"; // ścieżka do pliku konfiguracyjnego sieci
        private string xmlPathNode; // ścieżka do pliku konfiguracyjnego węzła

        private Configuration.NetworkElement networkElement;
        private Configuration.Network network;

        #region Konstruktor

        //Konstruktor okna węzła
        public SwitchWindow()
        {
            InitializeComponent();  // Inicjalizacja okna chmury
        }

        ~SwitchWindow()
        {
        }

        public SwitchWindow(string xmlPathNode)
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

                Switch = new Switch(networkElement);
                Switch.StartWorking(network.Info.CloudHost, network.Info.CloudPort1, network.Info.CloudPort2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia: " + ex.Message, "Switch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion


        #region Metody

        #endregion


        #region Klasy pomocnicze i inne przydatne rzeczy
        
        #endregion


        #region Kod wygenerowany przez Visual Studio 2013

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NodeWindow_Load(object sender, EventArgs e)
        {

            try
            {
                string dirPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                networkElement = Configuration.NetworkElement.deserialize(dirPath + "\\" + xmlPathNode);
                network = Configuration.Network.deserialize(dirPath + "\\" + xmlPathNetwork);
                switchNameBox.Text = networkElement.Info.Name;
                managerIPBox.Text = network.Info.ManagerHost;
                managerPortBox.Text = network.Info.ManagerPort1.ToString();

                cloudIPBox.Text = network.Info.CloudHost;
                cloudPort1Box.Text = network.Info.CloudPort1.ToString();
                cloudPort2Box.Text = network.Info.CloudPort2.ToString();

                Switch = new Switch(networkElement);

            }
            catch (Exception) { }
        }

        #endregion

        private void mappingRefreshButton_Click(object sender, EventArgs e)
        {
            foreach (Network.EntryMapping entry in Switch.Matrix.MappingTable.GetNextEntry())
            {
                string start = "  " + entry.start.Port + "  |  " + entry.start.VPI + "  |  " + entry.start.VCI ;
                string end = " | " + entry.end.Port + "  |  " + entry.end.VPI + "  |  " + entry.end.VCI;
 
                mappingTableBox.Items.Add(start + end);
            }
        }

        private void logRefreshButton_Click(object sender, EventArgs e)
        {
            while (!Switch.Log.Queue.IsEmpty)
            {
                string log = "";
                Switch.Log.Queue.TryDequeue(out log);
                switchLogBox.Text += log + Environment.NewLine + Environment.NewLine;
            }
        }

        private void SwitchWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void SwitchWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
        }


    }

}
