using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;
namespace Lab03_Bai02
{
    public partial class Form1 : Form
    {
        Socket listenerSocket;
        Socket client_socket;
        bool Stopconnection = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void StartUnsafeThread()
        {
            try
            {
                listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                listenerSocket.Bind(ip);
                listenerSocket.Listen(-1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            int bytes_received = 0;
            byte[] receive_bytes = new byte[1];
            try
            {
                Message_TextBox.Text = "Waiting for connection on port 8080...\n";
                client_socket = listenerSocket.Accept();
                Message_TextBox.Text += "Connected to " + client_socket.RemoteEndPoint.ToString() + "\n";
                Stopconnection = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            while (SocketConnected(client_socket))
            {
                try
                {
                    string data = "";
                    bytes_received = client_socket.Receive(receive_bytes);
                    data = Encoding.ASCII.GetString(receive_bytes, 0, bytes_received);
                    Message_TextBox.Text += data;
                }
                catch
                {
                    break;
                }
                if (Stopconnection)
                {
                    break;
                }
            }    
            listenerSocket.Close();
            Message_TextBox.Text = "";
            Message_TextBox.Text += "Connection closed\n";
        }

        bool SocketConnected(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }
        private void Listen_Button_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(StartUnsafeThread));
            CheckForIllegalCrossThreadCalls = false;
            thread.Start();
        }
    }
}
