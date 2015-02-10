namespace Loki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RDPServer = new System.Windows.Forms.TextBox();
            this.RDPGateway = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.cbFullScreen = new System.Windows.Forms.CheckBox();
            this.UseNLA = new System.Windows.Forms.CheckBox();
            this.RDPPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.metasploitServer = new System.Windows.Forms.TextBox();
            this.metasploitPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RDPPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metasploitPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "RDP Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "RDP Gateway (Optional)";
            // 
            // RDPServer
            // 
            this.RDPServer.Location = new System.Drawing.Point(16, 31);
            this.RDPServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RDPServer.Name = "RDPServer";
            this.RDPServer.Size = new System.Drawing.Size(207, 22);
            this.RDPServer.TabIndex = 2;
            // 
            // RDPGateway
            // 
            this.RDPGateway.Location = new System.Drawing.Point(16, 79);
            this.RDPGateway.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RDPGateway.Name = "RDPGateway";
            this.RDPGateway.Size = new System.Drawing.Size(207, 22);
            this.RDPGateway.TabIndex = 3;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(140, 308);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 28);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // cbFullScreen
            // 
            this.cbFullScreen.AutoSize = true;
            this.cbFullScreen.Location = new System.Drawing.Point(16, 281);
            this.cbFullScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFullScreen.Name = "cbFullScreen";
            this.cbFullScreen.Size = new System.Drawing.Size(101, 21);
            this.cbFullScreen.TabIndex = 7;
            this.cbFullScreen.Text = "Full Screen";
            this.cbFullScreen.UseVisualStyleBackColor = true;
            this.cbFullScreen.CheckedChanged += new System.EventHandler(this.cbFullScreen_CheckedChanged);
            // 
            // UseNLA
            // 
            this.UseNLA.AutoSize = true;
            this.UseNLA.Checked = true;
            this.UseNLA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseNLA.Location = new System.Drawing.Point(16, 311);
            this.UseNLA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UseNLA.Name = "UseNLA";
            this.UseNLA.Size = new System.Drawing.Size(86, 21);
            this.UseNLA.TabIndex = 8;
            this.UseNLA.Text = "Use NLA";
            this.UseNLA.UseVisualStyleBackColor = true;
            this.UseNLA.CheckedChanged += new System.EventHandler(this.UseNLA_CheckedChanged);
            // 
            // RDPPort
            // 
            this.RDPPort.Location = new System.Drawing.Point(16, 127);
            this.RDPPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RDPPort.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
            this.RDPPort.Name = "RDPPort";
            this.RDPPort.Size = new System.Drawing.Size(160, 22);
            this.RDPPort.TabIndex = 9;
            this.RDPPort.Value = new decimal(new int[] {
            3389,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "RDP Port";
            // 
            // metasploitServer
            // 
            this.metasploitServer.Location = new System.Drawing.Point(16, 180);
            this.metasploitServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metasploitServer.Name = "metasploitServer";
            this.metasploitServer.Size = new System.Drawing.Size(207, 22);
            this.metasploitServer.TabIndex = 11;
            // 
            // metasploitPort
            // 
            this.metasploitPort.Location = new System.Drawing.Point(16, 233);
            this.metasploitPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metasploitPort.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
            this.metasploitPort.Name = "metasploitPort";
            this.metasploitPort.Size = new System.Drawing.Size(160, 22);
            this.metasploitPort.TabIndex = 12;
            this.metasploitPort.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Metasploit Server (Optional)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Metasploit Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 377);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.metasploitPort);
            this.Controls.Add(this.metasploitServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RDPPort);
            this.Controls.Add(this.UseNLA);
            this.Controls.Add(this.cbFullScreen);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.RDPGateway);
            this.Controls.Add(this.RDPServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Loki";
            ((System.ComponentModel.ISupportInitialize)(this.RDPPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metasploitPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.CheckBox cbFullScreen;
        public System.Windows.Forms.TextBox RDPServer;
        public System.Windows.Forms.TextBox RDPGateway;
        private System.Windows.Forms.CheckBox UseNLA;
        private System.Windows.Forms.NumericUpDown RDPPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox metasploitServer;
        private System.Windows.Forms.NumericUpDown metasploitPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

