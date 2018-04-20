using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        Socket client;
        byte[] data;
        IPEndPoint ipServer;

        public Form1()
        {
            InitializeComponent();
        }       
            
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(ipServer);
        }

        private void btnSendClient_Click(object sender, EventArgs e)
        {
            string text = txtMessageClient.Text;
            data = new byte[1024];
            data = Encoding.ASCII.GetBytes(text);
            txtMessageClient.Text = "";
            listBox1Client.Items.Add(text);
            client.Send(data);
            data = new byte[1024];
            client.Receive(data);
            text = Encoding.ASCII.GetString(data);
            listBox1Client.Items.Add(text);
        }

        
    }
}
