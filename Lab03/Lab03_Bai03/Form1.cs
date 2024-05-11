using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TCPServerOpen_Button_Click(object sender, EventArgs e)
        {
            TCPServer server = new TCPServer();
            server.Show();
        }

        private void TCPCilentOpen_Button_Click(object sender, EventArgs e)
        {
            Bai03_TCPCilent client = new Bai03_TCPCilent();
            client.Show();
        }
    }
}
