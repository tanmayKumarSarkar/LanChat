namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAddress = new System.Windows.Forms.ListBox();
            this.btnCnct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstName = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Ref = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "All IP Address";
            // 
            // lstAddress
            // 
            this.lstAddress.FormattingEnabled = true;
            this.lstAddress.Location = new System.Drawing.Point(70, 87);
            this.lstAddress.Name = "lstAddress";
            this.lstAddress.Size = new System.Drawing.Size(202, 225);
            this.lstAddress.TabIndex = 1;
            this.lstAddress.SelectedIndexChanged += new System.EventHandler(this.lstAddress_SelectedIndexChanged);
            // 
            // btnCnct
            // 
            this.btnCnct.Location = new System.Drawing.Point(400, 345);
            this.btnCnct.Name = "btnCnct";
            this.btnCnct.Size = new System.Drawing.Size(75, 23);
            this.btnCnct.TabIndex = 2;
            this.btnCnct.Text = "Connect";
            this.btnCnct.UseVisualStyleBackColor = true;
            this.btnCnct.Click += new System.EventHandler(this.btnCnct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Network Name";
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.Location = new System.Drawing.Point(273, 87);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(202, 225);
            this.lstName.TabIndex = 5;
            this.lstName.SelectedIndexChanged += new System.EventHandler(this.lstName_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Ref
            // 
            this.btn_Ref.Location = new System.Drawing.Point(307, 344);
            this.btn_Ref.Name = "btn_Ref";
            this.btn_Ref.Size = new System.Drawing.Size(75, 23);
            this.btn_Ref.TabIndex = 6;
            this.btn_Ref.Text = "Refresh";
            this.btn_Ref.UseVisualStyleBackColor = true;
            this.btn_Ref.Click += new System.EventHandler(this.btn_Ref_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 418);
            this.Controls.Add(this.btn_Ref);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCnct);
            this.Controls.Add(this.lstAddress);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Lan Chat";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAddress;
        private System.Windows.Forms.Button btnCnct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Ref;
    }
}