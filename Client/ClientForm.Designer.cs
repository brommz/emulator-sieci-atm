namespace Client
{
    partial class ClientWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.konfiguracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajKonfiguracjęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesGroupBox = new System.Windows.Forms.GroupBox();
            this.startCommunicationButton = new System.Windows.Forms.Button();
            this.outPortComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clientNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cloudPort1Box = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.networkSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.cloudPort2Box = new System.Windows.Forms.TextBox();
            this.cloudIPBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logRefreshButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.messagesGroupBox.SuspendLayout();
            this.networkSettingsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfiguracjaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(410, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "ClientMenu";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // konfiguracjaToolStripMenuItem
            // 
            this.konfiguracjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajKonfiguracjęToolStripMenuItem});
            this.konfiguracjaToolStripMenuItem.Name = "konfiguracjaToolStripMenuItem";
            this.konfiguracjaToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.konfiguracjaToolStripMenuItem.Text = "Konfiguracja";
            // 
            // wczytajKonfiguracjęToolStripMenuItem
            // 
            this.wczytajKonfiguracjęToolStripMenuItem.Name = "wczytajKonfiguracjęToolStripMenuItem";
            this.wczytajKonfiguracjęToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.wczytajKonfiguracjęToolStripMenuItem.Text = "Wczytaj konfigurację";
            // 
            // messagesGroupBox
            // 
            this.messagesGroupBox.Controls.Add(this.startCommunicationButton);
            this.messagesGroupBox.Controls.Add(this.outPortComboBox);
            this.messagesGroupBox.Controls.Add(this.label4);
            this.messagesGroupBox.Location = new System.Drawing.Point(13, 149);
            this.messagesGroupBox.Name = "messagesGroupBox";
            this.messagesGroupBox.Size = new System.Drawing.Size(382, 70);
            this.messagesGroupBox.TabIndex = 2;
            this.messagesGroupBox.TabStop = false;
            this.messagesGroupBox.Text = "Wysyłanie wiadomości";
            // 
            // startCommunicationButton
            // 
            this.startCommunicationButton.Location = new System.Drawing.Point(145, 37);
            this.startCommunicationButton.Name = "startCommunicationButton";
            this.startCommunicationButton.Size = new System.Drawing.Size(152, 21);
            this.startCommunicationButton.TabIndex = 6;
            this.startCommunicationButton.Text = "Rozpocznij komunikację";
            this.startCommunicationButton.UseVisualStyleBackColor = true;
            this.startCommunicationButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // outPortComboBox
            // 
            this.outPortComboBox.FormattingEnabled = true;
            this.outPortComboBox.Location = new System.Drawing.Point(10, 37);
            this.outPortComboBox.Name = "outPortComboBox";
            this.outPortComboBox.Size = new System.Drawing.Size(129, 21);
            this.outPortComboBox.TabIndex = 5;
            this.outPortComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wybierz port wyjściowy do komunikacji z innym klientem:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // clientNameBox
            // 
            this.clientNameBox.Location = new System.Drawing.Point(90, 21);
            this.clientNameBox.Name = "clientNameBox";
            this.clientNameBox.Size = new System.Drawing.Size(138, 20);
            this.clientNameBox.TabIndex = 0;
            this.clientNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa klienta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numery portów chmury kablowej:";
            // 
            // cloudPort1Box
            // 
            this.cloudPort1Box.Location = new System.Drawing.Point(176, 68);
            this.cloudPort1Box.Name = "cloudPort1Box";
            this.cloudPort1Box.Size = new System.Drawing.Size(52, 20);
            this.cloudPort1Box.TabIndex = 2;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(239, 51);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(139, 29);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Dołącz do sieci";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // networkSettingsGroupBox
            // 
            this.networkSettingsGroupBox.Controls.Add(this.cloudPort2Box);
            this.networkSettingsGroupBox.Controls.Add(this.cloudIPBox);
            this.networkSettingsGroupBox.Controls.Add(this.label8);
            this.networkSettingsGroupBox.Controls.Add(this.connectButton);
            this.networkSettingsGroupBox.Controls.Add(this.cloudPort1Box);
            this.networkSettingsGroupBox.Controls.Add(this.label3);
            this.networkSettingsGroupBox.Controls.Add(this.label1);
            this.networkSettingsGroupBox.Controls.Add(this.clientNameBox);
            this.networkSettingsGroupBox.Location = new System.Drawing.Point(13, 27);
            this.networkSettingsGroupBox.Name = "networkSettingsGroupBox";
            this.networkSettingsGroupBox.Size = new System.Drawing.Size(384, 116);
            this.networkSettingsGroupBox.TabIndex = 1;
            this.networkSettingsGroupBox.TabStop = false;
            this.networkSettingsGroupBox.Text = "Ustawienia sieciowe";
            this.networkSettingsGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cloudPort2Box
            // 
            this.cloudPort2Box.Location = new System.Drawing.Point(176, 90);
            this.cloudPort2Box.Name = "cloudPort2Box";
            this.cloudPort2Box.Size = new System.Drawing.Size(52, 20);
            this.cloudPort2Box.TabIndex = 3;
            // 
            // cloudIPBox
            // 
            this.cloudIPBox.Location = new System.Drawing.Point(145, 45);
            this.cloudIPBox.Name = "cloudIPBox";
            this.cloudIPBox.Size = new System.Drawing.Size(83, 20);
            this.cloudIPBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Adres IP chmury kablowej:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logRefreshButton);
            this.groupBox1.Controls.Add(this.logTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 153);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dziennik zdarzeń";
            // 
            // logRefreshButton
            // 
            this.logRefreshButton.Location = new System.Drawing.Point(247, 120);
            this.logRefreshButton.Name = "logRefreshButton";
            this.logRefreshButton.Size = new System.Drawing.Size(124, 23);
            this.logRefreshButton.TabIndex = 10;
            this.logRefreshButton.Text = "Odśwież zdarzenia";
            this.logRefreshButton.UseVisualStyleBackColor = true;
            this.logRefreshButton.Click += new System.EventHandler(this.logRefreshButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(9, 19);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(362, 95);
            this.logTextBox.TabIndex = 9;
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.messagesGroupBox);
            this.Controls.Add(this.networkSettingsGroupBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "ClientWindow";
            this.Text = "Klient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientWindow_FormClosed);
            this.Load += new System.EventHandler(this.ClientWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.messagesGroupBox.ResumeLayout(false);
            this.messagesGroupBox.PerformLayout();
            this.networkSettingsGroupBox.ResumeLayout(false);
            this.networkSettingsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem konfiguracjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajKonfiguracjęToolStripMenuItem;
        private System.Windows.Forms.GroupBox messagesGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox outPortComboBox;
        private System.Windows.Forms.TextBox clientNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cloudPort1Box;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.GroupBox networkSettingsGroupBox;
        private System.Windows.Forms.TextBox cloudIPBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button startCommunicationButton;
        private System.Windows.Forms.TextBox cloudPort2Box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button logRefreshButton;
        private System.Windows.Forms.TextBox logTextBox;
    }
}

