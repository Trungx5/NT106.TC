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
using System.Threading;
namespace Lab03_Bai03
{
    public partial class Bai03_TCPCilent : Form
    {
        TcpClient tcpClient;
        IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        IPEndPoint ipEndPoint;
        NetworkStream ns;
        Byte[] data;
        public Bai03_TCPCilent()
        {
            InitializeComponent();
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient = new TcpClient();
                ipEndPoint = new IPEndPoint(ipAddress, 8080);
                tcpClient.Connect(ipEndPoint);
                ns = tcpClient.GetStream();
                Send_Button.Enabled = true;
                Disconnect_Button.Enabled = true;
                Connect_Button.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection encounter some trouble, try again");
            }
        }


        private void Send_Button_Click_1(object sender, EventArgs e)
        {
            data = System.Text.Encoding.ASCII.GetBytes(Message_TextBox.Text + "\n");
            ns.Write(data, 0, data.Length);
            Message_TextBox.Text = "";
        }

        private void Disconnect_Button_Click_1(object sender, EventArgs e)
        {
            data = System.Text.Encoding.ASCII.GetBytes("quit\n");
            ns.Write(data, 0, data.Length);
            ns.Close();
            tcpClient.Close();
            Connect_Button.Enabled = true;
            Disconnect_Button.Enabled = false;
            Send_Button.Enabled = false;
        }
    }
}
