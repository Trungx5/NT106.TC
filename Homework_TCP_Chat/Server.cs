using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_TCP_Chat
{
    public partial class Server : Form
    {
        private List<TcpClient> connectedClients = new List<TcpClient>();
        public Server()
        {
            InitializeComponent();
        }
        SimpleTCP.SimpleTcpServer server;

        private void End_Click(object sender, EventArgs e)
        {

        }

        private void Server_Load(object sender, EventArgs e)
        {
            server = new SimpleTCP.SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF7;
            server.DataReceived += Server_DataReceived;
            server.ClientConnected += Server_ClientConnected; 
            server.ClientDisconnected += Server_ClientDisconnected; 
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtBox_Status.Invoke((MethodInvoker)delegate ()
            {
                txtBox_Status.Text += e.MessageString;
                if (e.TcpClient.Connected)  
                {
                    try
                    {
                        e.ReplyLine(string.Format("Bạn nhắn: {0}", e.MessageString));
                    }
                    catch (Exception ex)
                    {
                        txtBox_Status.Text += "Lỗi không gửi được: " + ex.Message;
                    }
                }
            });
        }
        private void Server_ClientConnected(object sender, TcpClient e) // Add this method
        {
            connectedClients.Add(e);
        }
        private void Server_ClientDisconnected(object sender, TcpClient e) // Add this method
        {
            connectedClients.Remove(e);
        }
        private void txtBox_Status_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(Host.Text);
                txtBox_Status.Text += "Server bắt đầu";
                server.Start(ip, Convert.ToInt32(Port.Text));
            }
            catch (FormatException)
            {
                txtBox_Status.Text += "Lỗi: IP không hợp lệ.";
            }
            catch (Exception ex)
            {
                txtBox_Status.Text += "Lỗi: " + ex.Message;
            }
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
        }
    }
}
