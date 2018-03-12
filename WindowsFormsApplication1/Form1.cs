using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        UdpClient udpServer ;
        Int32 serverPort = 220;

        private readonly ManualResetEvent myEvent = new ManualResetEvent(true);
        String txtRcvMsg;

        public Form1()
        {
            InitializeComponent();
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
            //All Ips -->> IPAddress[] ips = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFrndIp.Text = GetLocalIP();
            txtMyIp.Text = GetLocalIP();
            txtFrndPort.Text = serverPort.ToString();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            /*
            udpServer = new UdpClient(serverPort);

            while (true) {
                var remoteEp = new IPEndPoint(IPAddress.Any, Convert.ToInt32(txtMyPort.Text));
                var data = udpServer.Receive(ref remoteEp);
                txtCheckValSer.Text = "receive data from " + remoteEp.ToString();
                udpServer.Send(new byte[] { 1 }, 1, remoteEp);
            }*/

            new Thread(RunOnAnotherThread).Start();
            myEvent.WaitOne();
            txtCheckValSer.Text = txtRcvMsg;

        }

        void RunOnAnotherThread() { 
            
            udpServer = new UdpClient(serverPort);

            while (true) {
                var remoteEp = new IPEndPoint(IPAddress.Any, Convert.ToInt32(txtMyPort.Text));
                var data = udpServer.Receive(ref remoteEp);
                txtRcvMsg = "receive data from " + remoteEp.ToString();
                MessageBox.Show(txtRcvMsg);
                udpServer.Send(new byte[] { 1 }, 1, remoteEp);
            }

            myEvent.Set();
        }

        private void btnConToServer_Click(object sender, EventArgs e)
        {
            var client = new UdpClient();
            IPEndPoint Ep = new IPEndPoint(IPAddress.Parse(txtMyIp.Text), Convert.ToInt32(txtMyPort.Text));
            client.Connect(Ep);
            client.Send(new byte[] { 1, 2, 3, 4, 5 }, 5);
            var receivedData = client.Receive(ref Ep);
            txtCheckValClnt.Text = "receive data from " + Ep.ToString();
        }

    }
}
