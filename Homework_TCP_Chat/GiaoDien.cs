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
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Server_Open_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void Cilent_Open_Click(object sender, EventArgs e)
        {
            Cilent cilent = new Cilent();
            cilent.Show();
        }
    }
}
