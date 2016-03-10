using System;
using System.Windows.Forms;
using MSTSCLib;

//Released as open source by NCC Group Plc - http://www.nccgroup.com/
//
//Developed by Dave Spencer, david [dot] spencer [at] nccgroup [dot] com
//
//http://www.github.com/nccgroup/Loki
//
//Released under AGPL see LICENSE for more information

namespace Loki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string sRDPServer = "";
        public static string sRDPGateway = "";
        public static string sMetasploitServer = "";
        public static int iMetasploitPort = 8080;
        public static int iKeypress_delay = 50;
        public static int iTimeout = 50; 
        public static bool FullScreen = false;
        public static bool NLA = true;
        public static int iRDPPort = 3389;
        

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            sRDPServer = RDPServer.Text;
            sRDPGateway = RDPGateway.Text;
            iRDPPort = Convert.ToInt32(RDPPort.Value);
            sMetasploitServer = metasploitServer.Text;
            iMetasploitPort = Convert.ToInt32(metasploitPort.Value);
            if (cbFullScreen.Checked == true)
            {
                FullScreen = true;
            }
            Loki secondForm = new Loki();
            secondForm.Show();
            if (UseNLA.Checked == true)
            {
                NLA = true;
            }
        }

        private void cbFullScreen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UseNLA_CheckedChanged(object sender, EventArgs e)
        {
            if (UseNLA.Checked == true)
            {
                NLA = true;
            }

            else
            {
                NLA = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void metasploitPort_ValueChanged(object sender, EventArgs e)
        {

        }
        private void Keypress_delay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timeout_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RDPGateway_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_IE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RDPPort_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
