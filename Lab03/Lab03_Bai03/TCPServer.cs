using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Drawing.Text;
using System.Threading;
namespace Lab03_Bai03
{
    public partial class TCPServer : Form
    {
        Socket clientSocket;
        Socket listenerSocket;
        NetworkStream ns;
        public TCPServer()
        {
            InitializeComponent();
        }

        private void TCPServer_Load(object sender, EventArgs e)
        {

        }

        private void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            MessageServer_TextBox.Text += "Server started!\n";
            clientSocket = listenerSocket.Accept();
            MessageServer_TextBox.Text += "Connection accepted from " + clientSocket.RemoteEndPoint.ToString() + "\n";
            ns = new NetworkStream(clientSocket);

            while(clientSocket.Connected)
            {
                StringBuilder receiveStringBuilder = new StringBuilder();
                while(true)
                {
                    bytesReceived = ns.Read(recv, 0, recv.Length);
                    string receivedData = Encoding.ASCII.GetString(recv);
                    receiveStringBuilder.Append(receivedData);
                    MessageServer_TextBox.Text = receiveStringBuilder.ToString();
                    if(bytesReceived == 0)
                    {
                        break;
                    }
                    if(receiveStringBuilder.ToString().EndsWith("quit\n"))
                    {
                        break;
                    }
                }
            }

        }
        private void Listen_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Listen_Button_Click_1(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thread = new Thread(new ThreadStart(StartUnsafeThread));
            thread.Start();
        }
    }
}
