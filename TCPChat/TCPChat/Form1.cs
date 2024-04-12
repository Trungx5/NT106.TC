using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLLChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cilent_Create_Button_Click(object sender, EventArgs e)
        {
            Cilent cilent = new Cilent();
            cilent.Show();
        }

        private void Server_Create_Button_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }
    }
}
