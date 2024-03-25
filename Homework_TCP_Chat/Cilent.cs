using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_TCP_Chat
{
    public partial class Cilent : Form
    {
        public Cilent()
        {
            InitializeComponent();
            
        }
        SimpleTCP.SimpleTcpClient cilent;


        private void Connect_Click(object sender, EventArgs e)
        {
            Connect.Enabled = false;
        }

        private void Cilent_Load(object sender, EventArgs e)
        {
            cilent = new SimpleTCP.SimpleTcpClient();
            cilent.StringEncoder = Encoding.UTF7;
            cilent.DataReceived += Cilent_DataReceived;
        }
        private void Cilent_DataReceived(object sender, SimpleTCP.Message e)
        {
            Message_Content_Box.Invoke((MethodInvoker)delegate ()
            {
                Message_Content_Box.Text += e.MessageString;
            });
        }

        private void Send_Message_Click(object sender, EventArgs e)
        {
            cilent.WriteLineAndGetReply(MessageBox.Text, TimeSpan.FromSeconds(3));
        }

        private void MessageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Message_Content_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
