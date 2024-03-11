using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string bieuthuc="";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bieuthuc += 1;
            labelHienThi.Text = bieuthuc;

        }

        private void button0_Click(object sender, EventArgs e)
        {
            bieuthuc += 0;
            labelHienThi.Text = bieuthuc;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bieuthuc += 2;
            labelHienThi.Text = bieuthuc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bieuthuc += 3;
            labelHienThi.Text = bieuthuc;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bieuthuc += 4;
            labelHienThi.Text = bieuthuc;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bieuthuc += 5;
            labelHienThi.Text = bieuthuc;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bieuthuc += 6;
            labelHienThi.Text = bieuthuc;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bieuthuc += 7;
            labelHienThi.Text = bieuthuc;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bieuthuc += 8;
            labelHienThi.Text = bieuthuc;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bieuthuc += 9;
            labelHienThi.Text = bieuthuc;
        }

        private void buttonCham_Click(object sender, EventArgs e)
        {
            bieuthuc += ".";
            labelHienThi.Text = bieuthuc;
        }

        private void buttonCong_Click(object sender, EventArgs e)
        {
            bieuthuc += " + ";
            labelHienThi.Text = bieuthuc;
        }

        private void buttonTru_Click(object sender, EventArgs e)
        {
            bieuthuc += " - ";
            labelHienThi.Text = bieuthuc;
        }

        private void buttonNhan_Click(object sender, EventArgs e)
        {
            bieuthuc += " * ";
            labelHienThi.Text = bieuthuc;
        }

        private void buttonChia_Click(object sender, EventArgs e)
        {
            bieuthuc += " / ";
            labelHienThi.Text = bieuthuc;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            labelHienThi.Text = "";
            bieuthuc = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            try
            {
                bieuthuc = bieuthuc.Substring(0, bieuthuc.Length - 1);
                labelHienThi.Text = bieuthuc;
            }
            catch
            { }
        }

       

        private void buttonBang_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                var kq = dt.Compute(bieuthuc, "");
                labelHienThi.Text = kq + "";
                bieuthuc = "";

            }
            catch
            {
                labelHienThi.Text = "Error";
                bieuthuc = "";

            }
           

        }
    }
}
