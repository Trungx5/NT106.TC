using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_GiaoDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bai01_Button_Click(object sender, EventArgs e)
        {
            //Open Lab03_Bai01 form
            Lab03_Bai01 Bai01 = new Lab03_Bai01();
            Bai01.Show();
            
        }
    }
}
