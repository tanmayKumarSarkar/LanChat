namespace WindowsFormsApplication1
{
    partial class FormChat
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtFrndPort = new System.Windows.Forms.TextBox();
            this.txtMyPort = new System.Windows.Forms.TextBox();
            this.txtFrndIp = new System.Windows.Forms.TextBox();
            this.txtMyIp = new System.Windows.Forms.TextBox();
            this.FrndPort = new System.Windows.Forms.Label();
            this.MyPort = new System.Windows.Forms.Label();
            this.FrndIp = new System.Windows.Forms.Label();
            this.MyIp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(479, 379);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(83, 27);
            this.btnSend.TabIndex = 32;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(16, 383);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(457, 20);
            this.txtMsg.TabIndex = 31;
            // 
            // lstMsg
            // 
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.Location = new System.Drawing.Point(16, 97);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(546, 238);
            this.lstMsg.TabIndex = 30;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(479, 20);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(83, 40);
            this.btnConnect.TabIndex = 29;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtFrndPort
            // 
            this.txtFrndPort.Location = new System.Drawing.Point(357, 53);
            this.txtFrndPort.Name = "txtFrndPort";
            this.txtFrndPort.Size = new System.Drawing.Size(93, 20);
            this.txtFrndPort.TabIndex = 28;
            // 
            // txtMyPort
            // 
            this.txtMyPort.Location = new System.Drawing.Point(357, 7);
            this.txtMyPort.Name = "txtMyPort";
            this.txtMyPort.Size = new System.Drawing.Size(93, 20);
            this.txtMyPort.TabIndex = 27;
            // 
            // txtFrndIp
            // 
            this.txtFrndIp.Location = new System.Drawing.Point(125, 52);
            this.txtFrndIp.Name = "txtFrndIp";
            this.txtFrndIp.Size = new System.Drawing.Size(136, 20);
            this.txtFrndIp.TabIndex = 26;
            // 
            // txtMyIp
            // 
            this.txtMyIp.Location = new System.Drawing.Point(125, 11);
            this.txtMyIp.Name = "txtMyIp";
            this.txtMyIp.Size = new System.Drawing.Size(136, 20);
            this.txtMyIp.TabIndex = 25;
            // 
            // FrndPort
            // 
            this.FrndPort.AutoSize = true;
            this.FrndPort.Location = new System.Drawing.Point(273, 56);
            this.FrndPort.Name = "FrndPort";
            this.FrndPort.Size = new System.Drawing.Size(74, 13);
            this.FrndPort.TabIndex = 24;
            this.FrndPort.Text = "Frend\'s PORT";
            // 
            // MyPort
            // 
            this.MyPort.AutoSize = true;
            this.MyPort.Location = new System.Drawing.Point(273, 14);
            this.MyPort.Name = "MyPort";
            this.MyPort.Size = new System.Drawing.Size(62, 13);
            this.MyPort.TabIndex = 23;
            this.MyPort.Text = "Your PORT";
            // 
            // FrndIp
            // 
            this.FrndIp.AutoSize = true;
            this.FrndIp.Location = new System.Drawing.Point(13, 56);
            this.FrndIp.Name = "FrndIp";
            this.FrndIp.Size = new System.Drawing.Size(97, 13);
            this.FrndIp.TabIndex = 22;
            this.FrndIp.Text = "Friend\'s IP Address";
            // 
            // MyIp
            // 
            this.MyIp.AutoSize = true;
            this.MyIp.Location = new System.Drawing.Point(13, 14);
            this.MyIp.Name = "MyIp";
            this.MyIp.Size = new System.Drawing.Size(83, 13);
            this.MyIp.TabIndex = 21;
            this.MyIp.Text = "Your IP Address";
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 421);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.lstMsg);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtFrndPort);
            this.Controls.Add(this.txtMyPort);
            this.Controls.Add(this.txtFrndIp);
            this.Controls.Add(this.txtMyIp);
            this.Controls.Add(this.FrndPort);
            this.Controls.Add(this.MyPort);
            this.Controls.Add(this.FrndIp);
            this.Controls.Add(this.MyIp);
            this.Name = "FormChat";
            this.Text = "Message Box";
            this.Load += new System.EventHandler(this.FormChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.ListBox lstMsg;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtFrndPort;
        private System.Windows.Forms.TextBox txtMyPort;
        private System.Windows.Forms.TextBox txtFrndIp;
        private System.Windows.Forms.TextBox txtMyIp;
        private System.Windows.Forms.Label FrndPort;
        private System.Windows.Forms.Label MyPort;
        private System.Windows.Forms.Label FrndIp;
        private System.Windows.Forms.Label MyIp;

    }
}