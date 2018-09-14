namespace Cloud
{
    partial class CloudWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloudWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.konfiguracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajKonfiguracjęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.cloudPort1Box = new System.Windows.Forms.TextBox();
            this.cloudIPBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.cloudPort2Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkListRefreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.logRefreshButton = new System.Windows.Forms.Button();
            this.cloudLogBox = new System.Windows.Forms.TextBox();
            this.mappingTableBox = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.networkConfigurationGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfiguracjaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(411, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "ClientMenu";
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
            // networkConfigurationGroupBox
            // 
            this.networkConfigurationGroupBox.Controls.Add(this.cloudPort1Box);
            this.networkConfigurationGroupBox.Controls.Add(this.cloudIPBox);
            this.networkConfigurationGroupBox.Controls.Add(this.label10);
            this.networkConfigurationGroupBox.Controls.Add(this.startButton);
            this.networkConfigurationGroupBox.Controls.Add(this.cloudPort2Box);
            this.networkConfigurationGroupBox.Controls.Add(this.label2);
            this.networkConfigurationGroupBox.Location = new System.Drawing.Point(13, 35);
            this.networkConfigurationGroupBox.Name = "networkConfigurationGroupBox";
            this.networkConfigurationGroupBox.Size = new System.Drawing.Size(385, 91);
            this.networkConfigurationGroupBox.TabIndex = 2;
            this.networkConfigurationGroupBox.TabStop = false;
            this.networkConfigurationGroupBox.Text = "Konfiguracja sieciowa";
            // 
            // cloudPort1Box
            // 
            this.cloudPort1Box.Location = new System.Drawing.Point(185, 41);
            this.cloudPort1Box.Name = "cloudPort1Box";
            this.cloudPort1Box.Size = new System.Drawing.Size(52, 20);
            this.cloudPort1Box.TabIndex = 1;
            // 
            // cloudIPBox
            // 
            this.cloudIPBox.Location = new System.Drawing.Point(144, 19);
            this.cloudIPBox.Name = "cloudIPBox";
            this.cloudIPBox.Size = new System.Drawing.Size(93, 20);
            this.cloudIPBox.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Adres IP chmury kablowej:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(250, 36);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 28);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Rozpocznij działanie";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // cloudPort2Box
            // 
            this.cloudPort2Box.Location = new System.Drawing.Point(185, 65);
            this.cloudPort2Box.Name = "cloudPort2Box";
            this.cloudPort2Box.Size = new System.Drawing.Size(52, 20);
            this.cloudPort2Box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numery wykorzystywanych portów:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mappingTableBox);
            this.groupBox2.Controls.Add(this.linkListRefreshButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 161);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inspektor łączy";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // linkListRefreshButton
            // 
            this.linkListRefreshButton.Location = new System.Drawing.Point(9, 133);
            this.linkListRefreshButton.Name = "linkListRefreshButton";
            this.linkListRefreshButton.Size = new System.Drawing.Size(140, 23);
            this.linkListRefreshButton.TabIndex = 5;
            this.linkListRefreshButton.Text = "Odśwież listę łączy";
            this.linkListRefreshButton.UseVisualStyleBackColor = true;
            this.linkListRefreshButton.Click += new System.EventHandler(this.linkListRefreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wybierz łącze:";
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.logRefreshButton);
            this.logGroupBox.Controls.Add(this.cloudLogBox);
            this.logGroupBox.Location = new System.Drawing.Point(13, 299);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(385, 156);
            this.logGroupBox.TabIndex = 5;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Dziennik zdarzeń";
            // 
            // logRefreshButton
            // 
            this.logRefreshButton.Location = new System.Drawing.Point(251, 128);
            this.logRefreshButton.Name = "logRefreshButton";
            this.logRefreshButton.Size = new System.Drawing.Size(124, 23);
            this.logRefreshButton.TabIndex = 7;
            this.logRefreshButton.Text = "Odśwież zdarzenia";
            this.logRefreshButton.UseVisualStyleBackColor = true;
            this.logRefreshButton.Click += new System.EventHandler(this.logRefreshButton_Click);
            // 
            // cloudLogBox
            // 
            this.cloudLogBox.Location = new System.Drawing.Point(9, 19);
            this.cloudLogBox.Multiline = true;
            this.cloudLogBox.Name = "cloudLogBox";
            this.cloudLogBox.ReadOnly = true;
            this.cloudLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cloudLogBox.Size = new System.Drawing.Size(366, 103);
            this.cloudLogBox.TabIndex = 6;
            // 
            // mappingTableBox
            // 
            this.mappingTableBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mappingTableBox.FormattingEnabled = true;
            this.mappingTableBox.ItemHeight = 14;
            this.mappingTableBox.Location = new System.Drawing.Point(6, 33);
            this.mappingTableBox.Name = "mappingTableBox";
            this.mappingTableBox.ScrollAlwaysVisible = true;
            this.mappingTableBox.Size = new System.Drawing.Size(346, 88);
            this.mappingTableBox.TabIndex = 8;
            // 
            // CloudWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 467);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.networkConfigurationGroupBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CloudWindow";
            this.Text = "Chmura kablowa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloudWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloudWindow_FormClosed);
            this.Load += new System.EventHandler(this.CloudWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.networkConfigurationGroupBox.ResumeLayout(false);
            this.networkConfigurationGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.logGroupBox.ResumeLayout(false);
            this.logGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem konfiguracjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajKonfiguracjęToolStripMenuItem;
        private System.Windows.Forms.GroupBox networkConfigurationGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox cloudPort2Box;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.TextBox cloudLogBox;
        private System.Windows.Forms.Button linkListRefreshButton;
        private System.Windows.Forms.TextBox cloudIPBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cloudPort1Box;
        private System.Windows.Forms.Button logRefreshButton;
        private System.Windows.Forms.ListBox mappingTableBox;
    }
}

