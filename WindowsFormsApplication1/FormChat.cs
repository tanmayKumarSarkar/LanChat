using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormChat : Form
    {
        Socket sckCommunication;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        public string strngIp;
        private string myIpStr;
        private string myPortStr;
        private string FrndIpStr;
        private string FrndPortStr;
        Int32 serverPort = 220;

        private string UserType ;
        private bool isFirstConMsg = true;

        public FormChat()
        {
            InitializeComponent();
        }
        public FormChat( string strIp , string UserType)
        {
            InitializeComponent();
            this.strngIp = strIp;
            this.UserType = UserType;
        }


        private void FormChat_Load(object sender, EventArgs e)
        {
            sckCommunication = new Socket(AddressFamily.InterNetwork,
                        SocketType.Dgram, ProtocolType.Udp);
            sckCommunication.SetSocketOption(SocketOptionLevel.Socket,
                                SocketOptionName.ReuseAddress, true);

            FrndIpStr = strngIp.Split(':')[0].ToString();
            FrndPortStr = strngIp.Split(':')[1].ToString();
            txtFrndIp.Text = FrndIpStr;
            txtFrndPort.Text = FrndPortStr;
            txtMyIp.Text = GetLocalIP();
            txtMyPort.Text = serverPort.ToString();
            this.Text = "Message box " + UserType.Replace("User", "");

            btnConnect.PerformClick();
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // bind socket                        
            epLocal = new IPEndPoint(IPAddress.Parse(txtMyIp.Text),
                                    Convert.ToInt32(txtMyPort.Text));
            sckCommunication.Bind(epLocal);

            // connect to remote ip and port 
            epRemote = new IPEndPoint(IPAddress.Parse(txtFrndIp.Text),
                                    Convert.ToInt32(txtFrndPort.Text));
            sckCommunication.Connect(epRemote);

            // starts to listen to an specific port
            buffer = new byte[1464];
            sckCommunication.BeginReceiveFrom(buffer, 0, buffer.Length,
                                     SocketFlags.None, ref epRemote,
                            new AsyncCallback(OperatorCallBack), buffer);

            // release button to send message
            btnConnect.Enabled = false;
            btnConnect.Text = "Connected..";
            btnSend.Enabled = true;

            if (UserType == "UserSender")
            {
                btnSend.PerformClick();
            }
        }

        private void OperatorCallBack(IAsyncResult ar)
        {
            try
            {
                int size = sckCommunication.EndReceiveFrom(ar, ref epRemote);

                // check if theres actually information
                if (size > 0)
                {
                    // used to help us on getting the data
                    byte[] aux = new byte[1464];

                    // gets the data
                    aux = (byte[])ar.AsyncState;

                    // converts from data[] to string
                    ASCIIEncoding enc = new ASCIIEncoding();
                    string msg = enc.GetString(aux);

                    // adds to listbox
                    lstMsg.Items.Add("Friend: " + msg);
                }

                // starts to listen again
                buffer = new byte[1464];
                sckCommunication.BeginReceiveFrom(buffer, 0,
                                    buffer.Length, SocketFlags.None,
                    ref epRemote, new AsyncCallback(OperatorCallBack), buffer);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // converts from string to byte[]
            System.Text.ASCIIEncoding enc =
                  new System.Text.ASCIIEncoding();
            byte[] msg = new byte[1464];

            if ((UserType == "UserSender") && isFirstConMsg == true)
            {
                isFirstConMsg = false;

                msg = enc.GetBytes("ConnectionRequest");

                sckCommunication.Send(msg);
            }
            else
            {

                msg = enc.GetBytes(txtMsg.Text);

                // sending the message
                sckCommunication.Send(msg);

                // add to listbox
                lstMsg.Items.Add("You: " + txtMsg.Text);

                // clear txtMessage
                txtMsg.Clear();
            }
        }

    }
}
