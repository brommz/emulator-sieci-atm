namespace Manager
{
    partial class ManagerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerWindow));
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.managerLogBox = new System.Windows.Forms.TextBox();
            this.networkSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.managerIPBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.managerPortBox = new System.Windows.Forms.TextBox();
            this.nodesManagementGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mappingTableInspectorBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.deleteEntryButton = new System.Windows.Forms.Button();
            this.saveEntryButton = new System.Windows.Forms.Button();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.outVPIBox = new System.Windows.Forms.TextBox();
            this.outPortBox = new System.Windows.Forms.TextBox();
            this.inVCIBox = new System.Windows.Forms.TextBox();
            this.inVPIBox = new System.Windows.Forms.TextBox();
            this.inPortBox = new System.Windows.Forms.TextBox();
            this.outVCIBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nodesListRefreshButton = new System.Windows.Forms.Button();
            this.nodesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logRefreshButton = new System.Windows.Forms.Button();
            this.logGroupBox.SuspendLayout();
            this.networkSettingsGroupBox.SuspendLayout();
            this.nodesManagementGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.logRefreshButton);
            this.logGroupBox.Controls.Add(this.managerLogBox);
            this.logGroupBox.Location = new System.Drawing.Point(12, 402);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(556, 151);
            this.logGroupBox.TabIndex = 6;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Dziennik zdarzeń";
            // 
            // managerLogBox
            // 
            this.managerLogBox.Location = new System.Drawing.Point(6, 20);
            this.managerLogBox.Multiline = true;
            this.managerLogBox.Name = "managerLogBox";
            this.managerLogBox.ReadOnly = true;
            this.managerLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.managerLogBox.Size = new System.Drawing.Size(535, 95);
            this.managerLogBox.TabIndex = 16;
            // 
            // networkSettingsGroupBox
            // 
            this.networkSettingsGroupBox.Controls.Add(this.label15);
            this.networkSettingsGroupBox.Controls.Add(this.managerIPBox);
            this.networkSettingsGroupBox.Controls.Add(this.label2);
            this.networkSettingsGroupBox.Controls.Add(this.startButton);
            this.networkSettingsGroupBox.Controls.Add(this.managerPortBox);
            this.networkSettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.networkSettingsGroupBox.Name = "networkSettingsGroupBox";
            this.networkSettingsGroupBox.Size = new System.Drawing.Size(553, 74);
            this.networkSettingsGroupBox.TabIndex = 9;
            this.networkSettingsGroupBox.TabStop = false;
            this.networkSettingsGroupBox.Text = "Ustawienia sieciowe";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Adres IP zarządcy:";
            // 
            // managerIPBox
            // 
            this.managerIPBox.Location = new System.Drawing.Point(107, 19);
            this.managerIPBox.Name = "managerIPBox";
            this.managerIPBox.Size = new System.Drawing.Size(130, 20);
            this.managerIPBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Numer wykorzystywanego portu:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(243, 26);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 28);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Rozpocznij działanie";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // managerPortBox
            // 
            this.managerPortBox.Location = new System.Drawing.Point(172, 42);
            this.managerPortBox.Name = "managerPortBox";
            this.managerPortBox.Size = new System.Drawing.Size(65, 20);
            this.managerPortBox.TabIndex = 2;
            // 
            // nodesManagementGroupBox
            // 
            this.nodesManagementGroupBox.Controls.Add(this.label5);
            this.nodesManagementGroupBox.Controls.Add(this.label6);
            this.nodesManagementGroupBox.Controls.Add(this.label7);
            this.nodesManagementGroupBox.Controls.Add(this.label8);
            this.nodesManagementGroupBox.Controls.Add(this.label9);
            this.nodesManagementGroupBox.Controls.Add(this.mappingTableInspectorBox);
            this.nodesManagementGroupBox.Controls.Add(this.label10);
            this.nodesManagementGroupBox.Controls.Add(this.label18);
            this.nodesManagementGroupBox.Controls.Add(this.label19);
            this.nodesManagementGroupBox.Controls.Add(this.label20);
            this.nodesManagementGroupBox.Controls.Add(this.label21);
            this.nodesManagementGroupBox.Controls.Add(this.label22);
            this.nodesManagementGroupBox.Controls.Add(this.deleteEntryButton);
            this.nodesManagementGroupBox.Controls.Add(this.saveEntryButton);
            this.nodesManagementGroupBox.Controls.Add(this.addEntryButton);
            this.nodesManagementGroupBox.Controls.Add(this.label17);
            this.nodesManagementGroupBox.Controls.Add(this.label16);
            this.nodesManagementGroupBox.Controls.Add(this.label14);
            this.nodesManagementGroupBox.Controls.Add(this.label13);
            this.nodesManagementGroupBox.Controls.Add(this.label12);
            this.nodesManagementGroupBox.Controls.Add(this.label11);
            this.nodesManagementGroupBox.Controls.Add(this.outVPIBox);
            this.nodesManagementGroupBox.Controls.Add(this.outPortBox);
            this.nodesManagementGroupBox.Controls.Add(this.inVCIBox);
            this.nodesManagementGroupBox.Controls.Add(this.inVPIBox);
            this.nodesManagementGroupBox.Controls.Add(this.inPortBox);
            this.nodesManagementGroupBox.Controls.Add(this.outVCIBox);
            this.nodesManagementGroupBox.Controls.Add(this.label4);
            this.nodesManagementGroupBox.Controls.Add(this.label3);
            this.nodesManagementGroupBox.Controls.Add(this.nodesListRefreshButton);
            this.nodesManagementGroupBox.Controls.Add(this.nodesListBox);
            this.nodesManagementGroupBox.Controls.Add(this.label1);
            this.nodesManagementGroupBox.Location = new System.Drawing.Point(15, 93);
            this.nodesManagementGroupBox.Name = "nodesManagementGroupBox";
            this.nodesManagementGroupBox.Size = new System.Drawing.Size(553, 303);
            this.nodesManagementGroupBox.TabIndex = 10;
            this.nodesManagementGroupBox.TabStop = false;
            this.nodesManagementGroupBox.Text = "Zarządzanie węzłami sieciowymi";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(285, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "|";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(382, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "|";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(432, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "|";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(334, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "|";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(236, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "|";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mappingTableInspectorBox
            // 
            this.mappingTableInspectorBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mappingTableInspectorBox.FormattingEnabled = true;
            this.mappingTableInspectorBox.ItemHeight = 14;
            this.mappingTableInspectorBox.Location = new System.Drawing.Point(193, 84);
            this.mappingTableInspectorBox.Name = "mappingTableInspectorBox";
            this.mappingTableInspectorBox.ScrollAlwaysVisible = true;
            this.mappingTableInspectorBox.Size = new System.Drawing.Size(312, 130);
            this.mappingTableInspectorBox.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(394, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "VPI wy";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(345, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "port wy";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(198, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "port we";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(443, 68);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 39;
            this.label20.Text = "VCI wy";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(296, 68);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "VCI we";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(247, 68);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 36;
            this.label22.Text = "VPI we";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteEntryButton
            // 
            this.deleteEntryButton.Location = new System.Drawing.Point(290, 274);
            this.deleteEntryButton.Name = "deleteEntryButton";
            this.deleteEntryButton.Size = new System.Drawing.Size(119, 23);
            this.deleteEntryButton.TabIndex = 14;
            this.deleteEntryButton.Text = "Usuń wpis";
            this.deleteEntryButton.UseVisualStyleBackColor = true;
            // 
            // saveEntryButton
            // 
            this.saveEntryButton.Location = new System.Drawing.Point(414, 274);
            this.saveEntryButton.Name = "saveEntryButton";
            this.saveEntryButton.Size = new System.Drawing.Size(122, 23);
            this.saveEntryButton.TabIndex = 15;
            this.saveEntryButton.Text = "Zachowaj wpis";
            this.saveEntryButton.UseVisualStyleBackColor = true;
            // 
            // addEntryButton
            // 
            this.addEntryButton.Location = new System.Drawing.Point(166, 274);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(119, 23);
            this.addEntryButton.TabIndex = 13;
            this.addEntryButton.Text = "Dodaj wpis";
            this.addEntryButton.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(422, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "VPI wy:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(359, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "port wy:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(297, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "VCI we:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(483, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "VCI wy:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "VPI we:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "port we:";
            // 
            // outVPIBox
            // 
            this.outVPIBox.Location = new System.Drawing.Point(414, 248);
            this.outVPIBox.Name = "outVPIBox";
            this.outVPIBox.Size = new System.Drawing.Size(57, 20);
            this.outVPIBox.TabIndex = 11;
            // 
            // outPortBox
            // 
            this.outPortBox.Location = new System.Drawing.Point(353, 248);
            this.outPortBox.Name = "outPortBox";
            this.outPortBox.Size = new System.Drawing.Size(55, 20);
            this.outPortBox.TabIndex = 10;
            // 
            // inVCIBox
            // 
            this.inVCIBox.Location = new System.Drawing.Point(291, 248);
            this.inVCIBox.Name = "inVCIBox";
            this.inVCIBox.Size = new System.Drawing.Size(55, 20);
            this.inVCIBox.TabIndex = 9;
            // 
            // inVPIBox
            // 
            this.inVPIBox.Location = new System.Drawing.Point(230, 248);
            this.inVPIBox.Name = "inVPIBox";
            this.inVPIBox.Size = new System.Drawing.Size(55, 20);
            this.inVPIBox.TabIndex = 8;
            // 
            // inPortBox
            // 
            this.inPortBox.Location = new System.Drawing.Point(169, 248);
            this.inPortBox.Name = "inPortBox";
            this.inPortBox.Size = new System.Drawing.Size(55, 20);
            this.inPortBox.TabIndex = 7;
            // 
            // outVCIBox
            // 
            this.outVCIBox.Location = new System.Drawing.Point(477, 248);
            this.outVCIBox.Name = "outVCIBox";
            this.outVCIBox.Size = new System.Drawing.Size(55, 20);
            this.outVCIBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Inspektor tablicy mapowań:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Wybierz wpis w tablicy, aby móc go zmodyfikować lub usunąć:";
            // 
            // nodesListRefreshButton
            // 
            this.nodesListRefreshButton.Location = new System.Drawing.Point(9, 274);
            this.nodesListRefreshButton.Name = "nodesListRefreshButton";
            this.nodesListRefreshButton.Size = new System.Drawing.Size(140, 23);
            this.nodesListRefreshButton.TabIndex = 5;
            this.nodesListRefreshButton.Text = "Odśwież listę węzłów";
            this.nodesListRefreshButton.UseVisualStyleBackColor = true;
            this.nodesListRefreshButton.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // nodesListBox
            // 
            this.nodesListBox.Location = new System.Drawing.Point(9, 42);
            this.nodesListBox.Name = "nodesListBox";
            this.nodesListBox.Size = new System.Drawing.Size(140, 225);
            this.nodesListBox.TabIndex = 4;
            this.nodesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Wybierz węzeł sieciowy:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logRefreshButton
            // 
            this.logRefreshButton.Location = new System.Drawing.Point(417, 121);
            this.logRefreshButton.Name = "logRefreshButton";
            this.logRefreshButton.Size = new System.Drawing.Size(124, 23);
            this.logRefreshButton.TabIndex = 17;
            this.logRefreshButton.Text = "Odśwież zdarzenia";
            this.logRefreshButton.UseVisualStyleBackColor = true;
            // 
            // ManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 565);
            this.Controls.Add(this.nodesManagementGroupBox);
            this.Controls.Add(this.networkSettingsGroupBox);
            this.Controls.Add(this.logGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagerWindow";
            this.Text = "Zarządca sieci";
            this.logGroupBox.ResumeLayout(false);
            this.logGroupBox.PerformLayout();
            this.networkSettingsGroupBox.ResumeLayout(false);
            this.networkSettingsGroupBox.PerformLayout();
            this.nodesManagementGroupBox.ResumeLayout(false);
            this.nodesManagementGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.TextBox managerLogBox;
        private System.Windows.Forms.GroupBox networkSettingsGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox managerPortBox;
        private System.Windows.Forms.GroupBox nodesManagementGroupBox;
        private System.Windows.Forms.Button nodesListRefreshButton;
        private System.Windows.Forms.ListBox nodesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteEntryButton;
        private System.Windows.Forms.Button saveEntryButton;
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox outVPIBox;
        private System.Windows.Forms.TextBox outPortBox;
        private System.Windows.Forms.TextBox inVCIBox;
        private System.Windows.Forms.TextBox inVPIBox;
        private System.Windows.Forms.TextBox inPortBox;
        private System.Windows.Forms.TextBox outVCIBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox managerIPBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox mappingTableInspectorBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button logRefreshButton;
    }
}

