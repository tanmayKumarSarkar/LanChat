namespace WindowsFormsApplication1
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
            this.MyIp = new System.Windows.Forms.Label();
            this.FrndIp = new System.Windows.Forms.Label();
            this.MyPort = new System.Windows.Forms.Label();
            this.FrndPort = new System.Windows.Forms.Label();
            this.txtMyIp = new System.Windows.Forms.TextBox();
            this.txtFrndIp = new System.Windows.Forms.TextBox();
            this.txtMyPort = new System.Windows.Forms.TextBox();
            this.txtFrndPort = new System.Windows.Forms.TextBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.txtCheckValSer = new System.Windows.Forms.TextBox();
            this.btnConToServer = new System.Windows.Forms.Button();
            this.txtCheckValClnt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MyIp
            // 
            this.MyIp.AutoSize = true;
            this.MyIp.Location = new System.Drawing.Point(17, 31);
            this.MyIp.Name = "MyIp";
            this.MyIp.Size = new System.Drawing.Size(83, 13);
            this.MyIp.TabIndex = 0;
            this.MyIp.Text = "Your IP Address";
            // 
            // FrndIp
            // 
            this.FrndIp.AutoSize = true;
            this.FrndIp.Location = new System.Drawing.Point(17, 58);
            this.FrndIp.Name = "FrndIp";
            this.FrndIp.Size = new System.Drawing.Size(97, 13);
            this.FrndIp.TabIndex = 1;
            this.FrndIp.Text = "Friend\'s IP Address";
            // 
            // MyPort
            // 
            this.MyPort.AutoSize = true;
            this.MyPort.Location = new System.Drawing.Point(277, 31);
            this.MyPort.Name = "MyPort";
            this.MyPort.Size = new System.Drawing.Size(62, 13);
            this.MyPort.TabIndex = 2;
            this.MyPort.Text = "Your PORT";
            // 
            // FrndPort
            // 
            this.FrndPort.AutoSize = true;
            this.FrndPort.Location = new System.Drawing.Point(277, 58);
            this.FrndPort.Name = "FrndPort";
            this.FrndPort.Size = new System.Drawing.Size(74, 13);
            this.FrndPort.TabIndex = 3;
            this.FrndPort.Text = "Frend\'s PORT";
            // 
            // txtMyIp
            // 
            this.txtMyIp.Location = new System.Drawing.Point(129, 28);
            this.txtMyIp.Name = "txtMyIp";
            this.txtMyIp.Size = new System.Drawing.Size(136, 20);
            this.txtMyIp.TabIndex = 4;
            // 
            // txtFrndIp
            // 
            this.txtFrndIp.Location = new System.Drawing.Point(129, 54);
            this.txtFrndIp.Name = "txtFrndIp";
            this.txtFrndIp.Size = new System.Drawing.Size(136, 20);
            this.txtFrndIp.TabIndex = 5;
            // 
            // txtMyPort
            // 
            this.txtMyPort.Location = new System.Drawing.Point(361, 24);
            this.txtMyPort.Name = "txtMyPort";
            this.txtMyPort.Size = new System.Drawing.Size(93, 20);
            this.txtMyPort.TabIndex = 6;
            // 
            // txtFrndPort
            // 
            this.txtFrndPort.Location = new System.Drawing.Point(361, 55);
            this.txtFrndPort.Name = "txtFrndPort";
            this.txtFrndPort.Size = new System.Drawing.Size(93, 20);
            this.txtFrndPort.TabIndex = 7;
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(483, 31);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 40);
            this.btnCon.TabIndex = 8;
            this.btnCon.Text = "Create Server";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // txtCheckValSer
            // 
            this.txtCheckValSer.Location = new System.Drawing.Point(20, 128);
            this.txtCheckValSer.Name = "txtCheckValSer";
            this.txtCheckValSer.Size = new System.Drawing.Size(538, 20);
            this.txtCheckValSer.TabIndex = 9;
            // 
            // btnConToServer
            // 
            this.btnConToServer.Location = new System.Drawing.Point(20, 80);
            this.btnConToServer.Name = "btnConToServer";
            this.btnConToServer.Size = new System.Drawing.Size(111, 40);
            this.btnConToServer.TabIndex = 10;
            this.btnConToServer.Text = "Connect Server";
            this.btnConToServer.UseVisualStyleBackColor = true;
            this.btnConToServer.Click += new System.EventHandler(this.btnConToServer_Click);
            // 
            // txtCheckValClnt
            // 
            this.txtCheckValClnt.Location = new System.Drawing.Point(20, 154);
            this.txtCheckValClnt.Name = "txtCheckValClnt";
            this.txtCheckValClnt.Size = new System.Drawing.Size(538, 20);
            this.txtCheckValClnt.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 398);
            this.Controls.Add(this.txtCheckValClnt);
            this.Controls.Add(this.btnConToServer);
            this.Controls.Add(this.txtCheckValSer);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtFrndPort);
            this.Controls.Add(this.txtMyPort);
            this.Controls.Add(this.txtFrndIp);
            this.Controls.Add(this.txtMyIp);
            this.Controls.Add(this.FrndPort);
            this.Controls.Add(this.MyPort);
            this.Controls.Add(this.FrndIp);
            this.Controls.Add(this.MyIp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyIp;
        private System.Windows.Forms.Label FrndIp;
        private System.Windows.Forms.Label MyPort;
        private System.Windows.Forms.Label FrndPort;
        private System.Windows.Forms.TextBox txtMyIp;
        private System.Windows.Forms.TextBox txtFrndIp;
        private System.Windows.Forms.TextBox txtMyPort;
        private System.Windows.Forms.TextBox txtFrndPort;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.TextBox txtCheckValSer;
        private System.Windows.Forms.Button btnConToServer;
        private System.Windows.Forms.TextBox txtCheckValClnt;
    }
}

