using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class UDP_Cilent : Form
    {
        public UDP_Cilent()
        {
            InitializeComponent();
        }

        private void UDPConnect()
        {
            Byte[] sendBytes = Encoding.ASCII.GetBytes(Message__TextBox.Text);
            UdpClient udpClient = new UdpClient();
            udpClient.Send(sendBytes, sendBytes.Length, IPRemote_TextBox.Text, int.Parse(Port_TextBox.Text));
               
        }

        private void UDP_Cilent_Load(object sender, EventArgs e)
        {

        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            UDPConnect();
        }

        private void IPRemote_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
