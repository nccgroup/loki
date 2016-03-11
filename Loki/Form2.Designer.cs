namespace Loki
{
    partial class Loki
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
            System.Windows.Forms.Panel panel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loki));
            this.rdp = new AxMSTSCLib.AxMsRdpClient7NotSafeForScripting();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lokiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFileSendKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sleipnirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFileOnVirtualChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFD1 = new System.Windows.Forms.OpenFileDialog();
            this.openFDToSendVC = new System.Windows.Forms.OpenFileDialog();
            this.progressBarLoki = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            panel1.AutoScroll = true;
            panel1.Controls.Add(this.rdp);
            panel1.Location = new System.Drawing.Point(0, 57);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1260, 889);
            panel1.TabIndex = 3;
            // 
            // rdp
            // 
            this.rdp.Enabled = true;
            this.rdp.Location = new System.Drawing.Point(9, 4);
            this.rdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdp.Name = "rdp";
            this.rdp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rdp.OcxState")));
            this.rdp.Size = new System.Drawing.Size(910, 882);
            this.rdp.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lokiToolStripMenuItem,
            this.sleipnirToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1261, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lokiToolStripMenuItem
            // 
            this.lokiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendFileSendKeysToolStripMenuItem});
            this.lokiToolStripMenuItem.Name = "lokiToolStripMenuItem";
            this.lokiToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.lokiToolStripMenuItem.Text = "Loki";
            // 
            // sendFileSendKeysToolStripMenuItem
            // 
            this.sendFileSendKeysToolStripMenuItem.Name = "sendFileSendKeysToolStripMenuItem";
            this.sendFileSendKeysToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.sendFileSendKeysToolStripMenuItem.Text = "Send File (SendKeys)";
            this.sendFileSendKeysToolStripMenuItem.Click += new System.EventHandler(this.sendFileSendKeysToolStripMenuItem_Click);
            // 
            // sleipnirToolStripMenuItem
            // 
            this.sleipnirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendFileOnVirtualChannelToolStripMenuItem});
            this.sleipnirToolStripMenuItem.Name = "sleipnirToolStripMenuItem";
            this.sleipnirToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.sleipnirToolStripMenuItem.Text = "Sleipnir";
            // 
            // sendFileOnVirtualChannelToolStripMenuItem
            // 
            this.sendFileOnVirtualChannelToolStripMenuItem.Name = "sendFileOnVirtualChannelToolStripMenuItem";
            this.sendFileOnVirtualChannelToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.sendFileOnVirtualChannelToolStripMenuItem.Text = "Send File On Virtual Channel";
            this.sendFileOnVirtualChannelToolStripMenuItem.Click += new System.EventHandler(this.sendFileOnVirtualChannelToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // openFD1
            // 
            this.openFD1.FileName = "openFileDialog1";
            // 
            // openFDToSendVC
            // 
            this.openFDToSendVC.FileName = "openFileDialog1";
            // 
            // progressBarLoki
            // 
            this.progressBarLoki.Location = new System.Drawing.Point(13, 32);
            this.progressBarLoki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarLoki.Name = "progressBarLoki";
            this.progressBarLoki.Size = new System.Drawing.Size(1244, 18);
            this.progressBarLoki.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Loki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1261, 880);
            this.Controls.Add(this.progressBarLoki);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Loki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Loki - RDP Connection";
            this.Load += new System.EventHandler(this.Form2_Load);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public AxMSTSCLib.AxMsRdpClient7NotSafeForScripting rdp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lokiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFileSendKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sleipnirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFD1;
        private System.Windows.Forms.ToolStripMenuItem sendFileOnVirtualChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFDToSendVC;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.ProgressBar progressBarLoki;


    }
}