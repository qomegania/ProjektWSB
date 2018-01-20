namespace Server
{
    partial class Form1
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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listBoxServer = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxIpAddress = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.webBrowserChat = new System.Windows.Forms.WebBrowser();
            this.backgroundWorkerMainLoop = new System.ComponentModel.BackgroundWorker();
            this.groupBoxAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.buttonRemove);
            this.groupBoxAdmin.Controls.Add(this.listBoxUsers);
            this.groupBoxAdmin.Controls.Add(this.label3);
            this.groupBoxAdmin.Controls.Add(this.buttonStop);
            this.groupBoxAdmin.Controls.Add(this.buttonStart);
            this.groupBoxAdmin.Controls.Add(this.listBoxServer);
            this.groupBoxAdmin.Controls.Add(this.label2);
            this.groupBoxAdmin.Controls.Add(this.numericUpDownPort);
            this.groupBoxAdmin.Controls.Add(this.label1);
            this.groupBoxAdmin.Controls.Add(this.comboBoxIpAddress);
            this.groupBoxAdmin.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(284, 581);
            this.groupBoxAdmin.TabIndex = 0;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Admin Panel";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(203, 267);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 16;
            this.listBoxUsers.Location = new System.Drawing.Point(6, 267);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(191, 308);
            this.listBoxUsers.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Users list:";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(203, 201);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(6, 201);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listBoxServer
            // 
            this.listBoxServer.FormattingEnabled = true;
            this.listBoxServer.ItemHeight = 16;
            this.listBoxServer.Location = new System.Drawing.Point(6, 79);
            this.listBoxServer.Name = "listBoxServer";
            this.listBoxServer.Size = new System.Drawing.Size(272, 116);
            this.listBoxServer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(132, 51);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(146, 22);
            this.numericUpDownPort.TabIndex = 1;
            this.numericUpDownPort.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address:";
            // 
            // comboBoxIpAddress
            // 
            this.comboBoxIpAddress.FormattingEnabled = true;
            this.comboBoxIpAddress.Location = new System.Drawing.Point(132, 21);
            this.comboBoxIpAddress.Name = "comboBoxIpAddress";
            this.comboBoxIpAddress.Size = new System.Drawing.Size(146, 24);
            this.comboBoxIpAddress.TabIndex = 1;
            this.comboBoxIpAddress.Text = "127.0.0.1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(803, 598);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Send";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 599);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(785, 22);
            this.textBoxMessage.TabIndex = 2;
            // 
            // webBrowserChat
            // 
            this.webBrowserChat.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserChat.Location = new System.Drawing.Point(302, 12);
            this.webBrowserChat.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserChat.Name = "webBrowserChat";
            this.webBrowserChat.Size = new System.Drawing.Size(576, 581);
            this.webBrowserChat.TabIndex = 3;
            this.webBrowserChat.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.webBrowserChat.WebBrowserShortcutsEnabled = false;
            // 
            // backgroundWorkerMainLoop
            // 
            this.backgroundWorkerMainLoop.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMainLoop_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 632);
            this.Controls.Add(this.webBrowserChat);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBoxAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listBoxServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxIpAddress;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.WebBrowser webBrowserChat;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMainLoop;
    }
}

