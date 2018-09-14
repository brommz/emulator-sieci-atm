namespace Client
{
    partial class ClientCommunicationWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outPortBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VCIBox = new System.Windows.Forms.TextBox();
            this.VPIBox = new System.Windows.Forms.TextBox();
            this.sendOnceButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.receivedRefreshButton = new System.Windows.Forms.Button();
            this.receivedMessagesBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outPortBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.VCIBox);
            this.groupBox1.Controls.Add(this.VPIBox);
            this.groupBox1.Controls.Add(this.sendOnceButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.messageBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 160);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wysyłanie wiadomości";
            // 
            // outPortBox
            // 
            this.outPortBox.Location = new System.Drawing.Point(291, 45);
            this.outPortBox.Name = "outPortBox";
            this.outPortBox.ReadOnly = true;
            this.outPortBox.Size = new System.Drawing.Size(93, 20);
            this.outPortBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Port wy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "VCI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "VPI:";
            // 
            // VCIBox
            // 
            this.VCIBox.Location = new System.Drawing.Point(163, 45);
            this.VCIBox.Name = "VCIBox";
            this.VCIBox.Size = new System.Drawing.Size(56, 20);
            this.VCIBox.TabIndex = 1;
            // 
            // VPIBox
            // 
            this.VPIBox.Location = new System.Drawing.Point(53, 45);
            this.VPIBox.Name = "VPIBox";
            this.VPIBox.Size = new System.Drawing.Size(56, 20);
            this.VPIBox.TabIndex = 0;
            // 
            // sendOnceButton
            // 
            this.sendOnceButton.Location = new System.Drawing.Point(265, 85);
            this.sendOnceButton.Name = "sendOnceButton";
            this.sendOnceButton.Size = new System.Drawing.Size(119, 28);
            this.sendOnceButton.TabIndex = 4;
            this.sendOnceButton.Text = "Wyślij raz";
            this.sendOnceButton.UseVisualStyleBackColor = true;
            this.sendOnceButton.Click += new System.EventHandler(this.sendOnceButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Wpisz wiadomość:";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(22, 86);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(237, 57);
            this.messageBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Wprowadź dane niezbędne do rozpoczęcia komunikacji:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.receivedRefreshButton);
            this.groupBox2.Controls.Add(this.receivedMessagesBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 131);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wiadomości odebrane";
            // 
            // receivedRefreshButton
            // 
            this.receivedRefreshButton.Location = new System.Drawing.Point(289, 95);
            this.receivedRefreshButton.Name = "receivedRefreshButton";
            this.receivedRefreshButton.Size = new System.Drawing.Size(89, 23);
            this.receivedRefreshButton.TabIndex = 7;
            this.receivedRefreshButton.Text = "Odśwież";
            this.receivedRefreshButton.UseVisualStyleBackColor = true;
            this.receivedRefreshButton.Click += new System.EventHandler(this.receivedRefreshButton_Click);
            // 
            // receivedMessagesBox
            // 
            this.receivedMessagesBox.Location = new System.Drawing.Point(16, 19);
            this.receivedMessagesBox.Multiline = true;
            this.receivedMessagesBox.Name = "receivedMessagesBox";
            this.receivedMessagesBox.ReadOnly = true;
            this.receivedMessagesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receivedMessagesBox.Size = new System.Drawing.Size(362, 70);
            this.receivedMessagesBox.TabIndex = 6;
            // 
            // ClientCommunicationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 321);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ClientCommunicationWindow";
            this.ShowIcon = false;
            this.Text = "Komunikacja z innym klientem";
            this.Load += new System.EventHandler(this.ClientCommunicationWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox outPortBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VCIBox;
        private System.Windows.Forms.TextBox VPIBox;
        private System.Windows.Forms.Button sendOnceButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button receivedRefreshButton;
        private System.Windows.Forms.TextBox receivedMessagesBox;

    }
}