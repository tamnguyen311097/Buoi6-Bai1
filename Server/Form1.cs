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

namespace Server
{
    public partial class Form1 : Form
    {
        Socket server, client;
        byte[] data;
        IPEndPoint ipClient;

        public Form1()
        {
            InitializeComponent();
        }

        private static void CallAccept(IAsyncResult iar)
        {
            Socket server = (Socket)iar.AsyncState;
            Socket client = server.EndAccept(iar);

            //Socket client = ((Socket)(iar.AsyncState)).EndAccept(iar);

            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

            newsock.BeginConnect(ipe, new AsyncCallback(Connected), newsock);

            //AsyncCallback con = new AsyncCallback(Connected);
            //newsock.BeginConnect(ipe, con, newsock);
        }

        private static void Connected(IAsyncResult iar)
        {
            Socket sock = (Socket)iar.AsyncState;
            sock.EndConnect(iar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPEndPoint ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipServer);
            server.Listen(5);
            //client = server.Accept();
            server.BeginAccept(new AsyncCallback(AcceptClient),


        server);
        }

        private void AcceptClient(IAsyncResult i)
        {
            client = ((Socket)(i.AsyncState)).EndAccept(i);
            data = new byte[1024];
            //client.Receive(data);
            client.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceiveData), client);

        }

        private void ReceiveData(IAsyncResult i)
        {
            ((Socket)i.AsyncState).EndAccept(i);
            listBox1Server.Items.Add("Client: " + Encoding.ASCII.GetString(data));
        }
        

        private void btnSendServer_Click(object sender, EventArgs e)
        {
            string text = txtMessageServer.Text;
            listBox1Server.Items.Add(text);
            txtMessageServer.Text = "";
            data = new byte[1024];
            data = Encoding.ASCII.GetBytes(text);
            client.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceiveData), client);
            data = new byte[1024];
            client.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceiveData), client);
            listBox1Server.Items.Add(Encoding.ASCII.GetString(data));
        }
    }
}
