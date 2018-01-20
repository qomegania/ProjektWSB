namespace Client
{
    partial class FormConnect
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
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.labelNick = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.webBrowserChat = new System.Windows.Forms.WebBrowser();
            this.backgroundWorkerChat = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(230, 678);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(535, 22);
            this.textBoxMessage.TabIndex = 0;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(771, 677);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxNick
            // 
            this.textBoxNick.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxNick.Location = new System.Drawing.Point(106, 21);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(100, 22);
            this.textBoxNick.TabIndex = 2;
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Location = new System.Drawing.Point(6, 24);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(35, 17);
            this.labelNick.TabIndex = 3;
            this.labelNick.Text = "Nick";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(68, 78);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(138, 23);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // webBrowserChat
            // 
            //this.webBrowserChat.IsWebBrowserContextMenuEnabled = false;
            //this.webBrowserChat.Location = new System.Drawing.Point(230, 13);
            //this.webBrowserChat.MinimumSize = new System.Drawing.Size(20, 20);
            //this.webBrowserChat.Name = "webBrowserChat";
            //this.webBrowserChat.Size = new System.Drawing.Size(616, 658);
            //this.webBrowserChat.TabIndex = 6;
            //this.webBrowserChat.Url = new System.Uri("auto:blank", System.UriKind.Absolute);
            //this.webBrowserChat.WebBrowserShortcutsEnabled = false;
            //this.webBrowserChat.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserChat_DocumentCompleted);
            this.webBrowserChat.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserChat.Location = new System.Drawing.Point(302, 12);
            this.webBrowserChat.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserChat.Name = "webBrowserChat";
            this.webBrowserChat.Size = new System.Drawing.Size(576, 581);
            this.webBrowserChat.TabIndex = 3;
            this.webBrowserChat.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.webBrowserChat.WebBrowserShortcutsEnabled = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.labelNick);
            this.groupBox1.Controls.Add(this.textBoxNick);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 688);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FormConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 712);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowserChat);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMessage);
            this.Name = "FormConnect";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorkerChat;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.WebBrowser webBrowserChat;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

