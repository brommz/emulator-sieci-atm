namespace Switch
{
    partial class SwitchWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwitchWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mappingInspectorGroupBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mappingTableBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mappingRefreshButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.logRefreshButton = new System.Windows.Forms.Button();
            this.switchLogBox = new System.Windows.Forms.TextBox();
            this.switchNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.managerPortBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cloudIPBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.managerIPBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cloudPort1Box = new System.Windows.Forms.TextBox();
            this.networkSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.cloudPort2Box = new System.Windows.Forms.TextBox();
            this.mappingInspectorGroupBox.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.networkSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(357, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "ClientMenu";
            // 
            // mappingInspectorGroupBox
            // 
            this.mappingInspectorGroupBox.Controls.Add(this.label16);
            this.mappingInspectorGroupBox.Controls.Add(this.label15);
            this.mappingInspectorGroupBox.Controls.Add(this.label14);
            this.mappingInspectorGroupBox.Controls.Add(this.label13);
            this.mappingInspectorGroupBox.Controls.Add(this.label5);
            this.mappingInspectorGroupBox.Controls.Add(this.mappingTableBox);
            this.mappingInspectorGroupBox.Controls.Add(this.label9);
            this.mappingInspectorGroupBox.Controls.Add(this.label6);
            this.mappingInspectorGroupBox.Controls.Add(this.label12);
            this.mappingInspectorGroupBox.Controls.Add(this.label10);
            this.mappingInspectorGroupBox.Controls.Add(this.mappingRefreshButton);
            this.mappingInspectorGroupBox.Controls.Add(this.label8);
            this.mappingInspectorGroupBox.Controls.Add(this.label7);
            this.mappingInspectorGroupBox.Location = new System.Drawing.Point(12, 206);
            this.mappingInspectorGroupBox.Name = "mappingInspectorGroupBox";
            this.mappingInspectorGroupBox.Size = new System.Drawing.Size(334, 203);
            this.mappingInspectorGroupBox.TabIndex = 3;
            this.mappingInspectorGroupBox.TabStop = false;
            this.mappingInspectorGroupBox.Text = "Inspektor tablicy mapowania";
            this.mappingInspectorGroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(102, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 15);
            this.label16.TabIndex = 14;
            this.label16.Text = "|";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(199, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 15);
            this.label15.TabIndex = 13;
            this.label15.Text = "|";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(249, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "|";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(151, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "|";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(53, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "|";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mappingTableBox
            // 
            this.mappingTableBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mappingTableBox.FormattingEnabled = true;
            this.mappingTableBox.ItemHeight = 14;
            this.mappingTableBox.Location = new System.Drawing.Point(10, 37);
            this.mappingTableBox.Name = "mappingTableBox";
            this.mappingTableBox.ScrollAlwaysVisible = true;
            this.mappingTableBox.Size = new System.Drawing.Size(312, 130);
            this.mappingTableBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(211, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "VPI wy";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(162, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "port wy";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(15, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "port we";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(260, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "VCI wy";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mappingRefreshButton
            // 
            this.mappingRefreshButton.Location = new System.Drawing.Point(9, 173);
            this.mappingRefreshButton.Name = "mappingRefreshButton";
            this.mappingRefreshButton.Size = new System.Drawing.Size(148, 23);
            this.mappingRefreshButton.TabIndex = 8;
            this.mappingRefreshButton.Text = "Odśwież mapowania";
            this.mappingRefreshButton.UseVisualStyleBackColor = true;
            this.mappingRefreshButton.Click += new System.EventHandler(this.mappingRefreshButton_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(113, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "VCI we";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(64, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "VPI we";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.logRefreshButton);
            this.logGroupBox.Controls.Add(this.switchLogBox);
            this.logGroupBox.Location = new System.Drawing.Point(12, 415);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(334, 153);
            this.logGroupBox.TabIndex = 4;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Dziennik zdarzeń";
            // 
            // logRefreshButton
            // 
            this.logRefreshButton.Location = new System.Drawing.Point(198, 123);
            this.logRefreshButton.Name = "logRefreshButton";
            this.logRefreshButton.Size = new System.Drawing.Size(124, 23);
            this.logRefreshButton.TabIndex = 10;
            this.logRefreshButton.Text = "Odśwież zdarzenia";
            this.logRefreshButton.UseVisualStyleBackColor = true;
            this.logRefreshButton.Click += new System.EventHandler(this.logRefreshButton_Click);
            // 
            // switchLogBox
            // 
            this.switchLogBox.Location = new System.Drawing.Point(9, 19);
            this.switchLogBox.Multiline = true;
            this.switchLogBox.Name = "switchLogBox";
            this.switchLogBox.ReadOnly = true;
            this.switchLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.switchLogBox.Size = new System.Drawing.Size(313, 95);
            this.switchLogBox.TabIndex = 9;
            // 
            // switchNameBox
            // 
            this.switchNameBox.Location = new System.Drawing.Point(88, 21);
            this.switchNameBox.Name = "switchNameBox";
            this.switchNameBox.Size = new System.Drawing.Size(140, 20);
            this.switchNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa węzła:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numer portu zarządcy sieci:";
            // 
            // managerPortBox
            // 
            this.managerPortBox.Location = new System.Drawing.Point(162, 70);
            this.managerPortBox.Name = "managerPortBox";
            this.managerPortBox.Size = new System.Drawing.Size(66, 20);
            this.managerPortBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numery portów chmury kablowej:";
            // 
            // cloudIPBox
            // 
            this.cloudIPBox.Location = new System.Drawing.Point(145, 95);
            this.cloudIPBox.Name = "cloudIPBox";
            this.cloudIPBox.Size = new System.Drawing.Size(83, 20);
            this.cloudIPBox.TabIndex = 3;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(234, 65);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(94, 29);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Dołącz do sieci";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adres IP zarządcy sieci:";
            // 
            // managerIPBox
            // 
            this.managerIPBox.Location = new System.Drawing.Point(145, 45);
            this.managerIPBox.Name = "managerIPBox";
            this.managerIPBox.Size = new System.Drawing.Size(83, 20);
            this.managerIPBox.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Adres IP chmury kablowej:";
            // 
            // cloudPort1Box
            // 
            this.cloudPort1Box.Location = new System.Drawing.Point(175, 120);
            this.cloudPort1Box.Name = "cloudPort1Box";
            this.cloudPort1Box.Size = new System.Drawing.Size(53, 20);
            this.cloudPort1Box.TabIndex = 4;
            // 
            // networkSettingsGroupBox
            // 
            this.networkSettingsGroupBox.Controls.Add(this.cloudPort2Box);
            this.networkSettingsGroupBox.Controls.Add(this.cloudPort1Box);
            this.networkSettingsGroupBox.Controls.Add(this.label11);
            this.networkSettingsGroupBox.Controls.Add(this.connectButton);
            this.networkSettingsGroupBox.Controls.Add(this.managerIPBox);
            this.networkSettingsGroupBox.Controls.Add(this.label4);
            this.networkSettingsGroupBox.Controls.Add(this.cloudIPBox);
            this.networkSettingsGroupBox.Controls.Add(this.label3);
            this.networkSettingsGroupBox.Controls.Add(this.managerPortBox);
            this.networkSettingsGroupBox.Controls.Add(this.label2);
            this.networkSettingsGroupBox.Controls.Add(this.label1);
            this.networkSettingsGroupBox.Controls.Add(this.switchNameBox);
            this.networkSettingsGroupBox.Location = new System.Drawing.Point(12, 27);
            this.networkSettingsGroupBox.Name = "networkSettingsGroupBox";
            this.networkSettingsGroupBox.Size = new System.Drawing.Size(334, 173);
            this.networkSettingsGroupBox.TabIndex = 2;
            this.networkSettingsGroupBox.TabStop = false;
            this.networkSettingsGroupBox.Text = "Ustawienia sieciowe";
            // 
            // cloudPort2Box
            // 
            this.cloudPort2Box.Location = new System.Drawing.Point(175, 144);
            this.cloudPort2Box.Name = "cloudPort2Box";
            this.cloudPort2Box.Size = new System.Drawing.Size(53, 20);
            this.cloudPort2Box.TabIndex = 5;
            // 
            // SwitchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 579);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.mappingInspectorGroupBox);
            this.Controls.Add(this.networkSettingsGroupBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SwitchWindow";
            this.Text = "Węzeł sieciowy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SwitchWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SwitchWindow_FormClosed);
            this.Load += new System.EventHandler(this.NodeWindow_Load);
            this.mappingInspectorGroupBox.ResumeLayout(false);
            this.mappingInspectorGroupBox.PerformLayout();
            this.logGroupBox.ResumeLayout(false);
            this.logGroupBox.PerformLayout();
            this.networkSettingsGroupBox.ResumeLayout(false);
            this.networkSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.GroupBox mappingInspectorGroupBox;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.TextBox switchLogBox;
        private System.Windows.Forms.Button mappingRefreshButton;
        private System.Windows.Forms.TextBox switchNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox managerPortBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cloudIPBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox managerIPBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cloudPort1Box;
        private System.Windows.Forms.GroupBox networkSettingsGroupBox;
        private System.Windows.Forms.ListBox mappingTableBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button logRefreshButton;
        private System.Windows.Forms.TextBox cloudPort2Box;
    }
}

