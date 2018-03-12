using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        UdpClient udpServer;
        Int32 serverPort = 220;

        private readonly ManualResetEvent myEvent = new ManualResetEvent(true);
        String txtRcvMsgSndr;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           //IPAddress[] ips = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            IPAddress[] ips = Array.FindAll(Dns.GetHostEntry(string.Empty).AddressList,a => a.AddressFamily == AddressFamily.InterNetwork);
            foreach (IPAddress address in ips)//Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                //if ((Dns.GetHostEntry(address).HostName != Dns.GetHostName()) && (address.GetAddressBytes()[0] > 0)) {
                lstAddress.Items.Add(address);
                lstName.Items.Add(Dns.GetHostEntry(address).HostName);
             // }
            }


            new Thread(RunOnAnotherThread).Start();
            myEvent.WaitOne();
            //txtCheckValSer.Text = txtRcvMsgSndr;

        }

        private void btnCnct_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lstAddress.SelectedIndex.ToString() + lstName.SelectedIndex.ToString());
            if (lstAddress.SelectedIndex != -1)
            {
               // MessageBox.Show(lstAddress.SelectedItem.ToString() + ":220");
               // Application.Run(new FormChat());
                FormChat cht = new FormChat(lstAddress.SelectedItem.ToString() + ":220", "UserSender");
                cht.Show();
            }
            
        }

        private string MakeSpaceStr(int no) {

            string text = "";
            for (int i = 1; i <= no; i++) {
                text = text + " ";
            }
            return text;
        }

        private void lstAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstName.SelectedIndex = lstAddress.SelectedIndex;
        }

        private void lstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAddress.SelectedIndex = lstName.SelectedIndex;
        }

        void RunOnAnotherThread()
        {
            try
            {
                udpServer = new UdpClient(serverPort);

                while (true)
                {
                    var remoteEp = new IPEndPoint(IPAddress.Any, serverPort);
                    Byte[] data = udpServer.Receive(ref remoteEp);
                    string rcvdData = Encoding.ASCII.GetString(data);
                    if (rcvdData == "ConnectionRequest")
                    {
                        //txtRcvMsg = "receive data from " + remoteEp.ToString();
                        //Application.Run(new FormChat(remoteEp.ToString() , "UserReceiver"));
                        new Thread(() => new FormChat(remoteEp.ToString(), "UserReceiver").ShowDialog()).Start();

                       // Activate();                        
                        //udpServer.Send(new byte[] { 1 }, 1, remoteEp);
                    }
                    //FormChat chtFrm = new FormChat(remoteEp.ToString());
                    //chtFrm.Show();
                    
                }

                myEvent.Set();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        void RunOnAnotherThread2()
        {
            try
            {
                udpServer = new UdpClient(serverPort);

                while (true)
                {
                    var remoteEp = new IPEndPoint(IPAddress.Any, serverPort);
                    Byte[] data = udpServer.Receive(ref remoteEp);
                    string rcvdData = Encoding.ASCII.GetString(data);
                    if (rcvdData == "ConnectionRequest")
                    {
                        //txtRcvMsg = "receive data from " + remoteEp.ToString();
                        //Application.Run(new FormChat(remoteEp.ToString() , "UserReceiver"));
                       // new Thread(() => new FormChat(remoteEp.ToString(), "UserReceiver").ShowDialog()).Start();
                        Thread t = new Thread(new ThreadStart(() =>
                        {
                            FormChat chtFrm = new FormChat(remoteEp.ToString(), "UserReceiver");
                            chtFrm.ShowDialog();
                            
                        }
                        ));
                        t.SetApartmentState(ApartmentState.STA);
                        t.IsBackground = true;
                        t.Start();
                    }
                    //FormChat chtFrm = new FormChat(remoteEp.ToString());
                    //chtFrm.Show();

                }

                myEvent.Set();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void btn_Ref_Click(object sender, EventArgs e) {

            lstAddress.Items.Clear();
            lstName.Items.Clear();
            //IPAddress[] ips = Array.FindAll(Dns.GetHostEntry(string.Empty).AddressList, a => a.AddressFamily == AddressFamily.InterNetwork);

            string computerName = System.Net.Dns.GetHostName();
            System.Net.IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(computerName);
            System.Net.IPAddress[] ipAddress = ipEntry.AddressList;

            
            

            foreach (IPAddress address in ipAddress)
            {
                computerName = "|" + ipAddress[1].ToString();
                if ((Dns.GetHostEntry(address).HostName != Dns.GetHostName()) && (address.GetAddressBytes()[0] > 0)) {
                lstAddress.Items.Add(computerName);
                lstName.Items.Add(Dns.GetHostEntry(address).HostName);
                }
            }
        }



    }
}
