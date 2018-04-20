namespace Server
{
    partial class Form1
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
            this.btnImagesServer = new System.Windows.Forms.Button();
            this.btnMusicsServer = new System.Windows.Forms.Button();
            this.btnFilesServer = new System.Windows.Forms.Button();
            this.btnSendServer = new System.Windows.Forms.Button();
            this.txtMessageServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1Server = new System.Windows.Forms.ListBox();
            this.txtClientIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImagesServer
            // 
            this.btnImagesServer.Location = new System.Drawing.Point(573, 182);
            this.btnImagesServer.Name = "btnImagesServer";
            this.btnImagesServer.Size = new System.Drawing.Size(82, 35);
            this.btnImagesServer.TabIndex = 26;
            this.btnImagesServer.Text = "Images";
            this.btnImagesServer.UseVisualStyleBackColor = true;
            // 
            // btnMusicsServer
            // 
            this.btnMusicsServer.Location = new System.Drawing.Point(573, 127);
            this.btnMusicsServer.Name = "btnMusicsServer";
            this.btnMusicsServer.Size = new System.Drawing.Size(82, 35);
            this.btnMusicsServer.TabIndex = 25;
            this.btnMusicsServer.Text = "Musics";
            this.btnMusicsServer.UseVisualStyleBackColor = true;
            // 
            // btnFilesServer
            // 
            this.btnFilesServer.Location = new System.Drawing.Point(573, 72);
            this.btnFilesServer.Name = "btnFilesServer";
            this.btnFilesServer.Size = new System.Drawing.Size(82, 35);
            this.btnFilesServer.TabIndex = 24;
            this.btnFilesServer.Text = "Files";
            this.btnFilesServer.UseVisualStyleBackColor = true;
            // 
            // btnSendServer
            // 
            this.btnSendServer.Location = new System.Drawing.Point(559, 312);
            this.btnSendServer.Name = "btnSendServer";
            this.btnSendServer.Size = new System.Drawing.Size(125, 97);
            this.btnSendServer.TabIndex = 23;
            this.btnSendServer.Text = "Send";
            this.btnSendServer.UseVisualStyleBackColor = true;
            this.btnSendServer.Click += new System.EventHandler(this.btnSendServer_Click);
            // 
            // txtMessageServer
            // 
            this.txtMessageServer.Location = new System.Drawing.Point(21, 312);
            this.txtMessageServer.Multiline = true;
            this.txtMessageServer.Name = "txtMessageServer";
            this.txtMessageServer.Size = new System.Drawing.Size(512, 97);
            this.txtMessageServer.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Message";
            // 
            // listBox1Server
            // 
            this.listBox1Server.FormattingEnabled = true;
            this.listBox1Server.ItemHeight = 16;
            this.listBox1Server.Location = new System.Drawing.Point(21, 61);
            this.listBox1Server.Name = "listBox1Server";
            this.listBox1Server.Size = new System.Drawing.Size(504, 196);
            this.listBox1Server.TabIndex = 20;
            // 
            // txtClientIP
            // 
            this.txtClientIP.Location = new System.Drawing.Point(102, 11);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(211, 22);
            this.txtClientIP.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Client IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 437);
            this.Controls.Add(this.btnImagesServer);
            this.Controls.Add(this.btnMusicsServer);
            this.Controls.Add(this.btnFilesServer);
            this.Controls.Add(this.btnSendServer);
            this.Controls.Add(this.txtMessageServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1Server);
            this.Controls.Add(this.txtClientIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImagesServer;
        private System.Windows.Forms.Button btnMusicsServer;
        private System.Windows.Forms.Button btnFilesServer;
        private System.Windows.Forms.Button btnSendServer;
        private System.Windows.Forms.TextBox txtMessageServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1Server;
        private System.Windows.Forms.TextBox txtClientIP;
        private System.Windows.Forms.Label label1;
    }
}

