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

namespace Cloud
{


    // Okno chmury kablowej (CloudWindow) tworzone jako formularz systemu Windows (Form)
    public partial class CloudWindow : Form
    {
        private Cloud cloud; // odpowiedzialne za logikę chmury

        private string xmlPath; // ścieżka do pliku konfiguracyjnego

        private Configuration.Network network;

        #region Konstruktor

        // Konstruktor okna chmury
        public CloudWindow()
        {
            InitializeComponent();  // Inicjalizacja okna chmury
        }

        ~CloudWindow()
        {
        }

        public CloudWindow(string xmlPath)
        {
            this.xmlPath = xmlPath;
            InitializeComponent();  // Inicjalizacja okna chmury
        }

        #endregion


        #region Składowe

        #endregion


        #region Zdarzenia interfejsu


        // Naciśnięcie przycisku "Rozpocznij działanie"
        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                network = Configuration.Network.deserialize(xmlPath);

                //cloud = new Cloud(network);
                cloud.StartWorking();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia: " + ex.Message, "Cloud", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion


        #region Metody

        #endregion


        #region Klasy pomocnicze i inne przydatne rzeczy

        #endregion


        #region Kod wygenerowany przez Visual Studio 2013

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void CloudWindow_Load(object sender, EventArgs e)
        {
            try
            {
                string dirPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                network = Configuration.Network.deserialize(dirPath + "\\" + xmlPath);
                cloudIPBox.Text = network.Info.CloudHost;
                cloudPort1Box.Text = network.Info.CloudPort1.ToString();
                cloudPort2Box.Text = network.Info.CloudPort2.ToString();

                cloud = new Cloud(network);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());  }
        }

        /* Metoda odpowiedzialna za odświeżanie i dodawanie zdarzeń logów */
        private void logRefreshButton_Click(object sender, EventArgs e)
        {
            while(!cloud.Log.Queue.IsEmpty)
            {
                string log = "";
                cloud.Log.Queue.TryDequeue(out log);
                cloudLogBox.Text += log + Environment.NewLine + Environment.NewLine;
            }
        }

        private void CloudWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void CloudWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void linkListRefreshButton_Click(object sender, EventArgs e)
        {
            mappingTableBox.Items.Add("  id  |  pt  | id  |  pt");
            foreach (Network.EntryForwarding entry in cloud.matrix.ForwardingTable.GetNextEntry())
            {
                string start = "  " + entry.start.ID + "  |  " + entry.start.Port;
                string end = " | " + entry.end.ID + "  |  " + entry.end.Port;
                mappingTableBox.Items.Add(start + end);
            }
        }


    }
}
