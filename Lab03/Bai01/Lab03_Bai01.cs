using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Lab03_Bai01 : Form
    {
        public Lab03_Bai01()
        {
            InitializeComponent();
        }

        private void Server_button_Click(object sender, EventArgs e)
        {
           UDP_Server server = new UDP_Server();
           server.Show();
        }

        private void Cilent_Button_Click(object sender, EventArgs e)
        {
           UDP_Cilent cilent = new UDP_Cilent();
           cilent.Show();
        }
    }
}
