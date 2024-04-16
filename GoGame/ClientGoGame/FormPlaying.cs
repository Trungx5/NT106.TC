using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientGoGame
{
    public partial class FormPlaying : Form
    {
        private const int BoardSize = 10;
        private const int SquareSize = 70;
        private Service service;
        private ChessBroad chessBroad = new ChessBroad();
        private int tableIndex;
        private int side;
        private bool isTurn = false;

        //check black or white
        private bool isBlack = false;
        /*  public FormPlaying()
          {
              InitializeComponent();
              InitializeGoBoard();
          }*/


        public FormPlaying(int TableIndex, int Side, StreamWriter sw)
        {

            InitializeComponent();
            
            this.tableIndex = TableIndex;
            this.side = Side;
            if (Side == 1)
            {
                labelSide.Text = "White";
                isBlack = false;
            }
            else
            {
                labelSide.Text = "Black";
                isBlack = true;
                isTurn = true;
            }
            service = new Service(listBox1, sw);
            InitializeGoBoard();
            //
            panel1.Visible=false;

        }
        private void InitializeGoBoard()
        {
            panel1.Width = panel1.Height = SquareSize * BoardSize;
            this.BackColor = Color.White;
        }

        private void DrawGoBoard(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            for (int i = 0; i < BoardSize - 1; i++)
            {
                g.DrawLine(pen, SquareSize, (i + 1) * SquareSize, SquareSize * (BoardSize - 1), (i + 1) * SquareSize);
                g.DrawLine(pen, (i + 1) * SquareSize, SquareSize, (i + 1) * SquareSize, SquareSize * (BoardSize - 1));
            }

            pen.Dispose();
        }

        private void DrawCircle(Graphics g, Brush brush, int x, int y, int diameter)
        {
            g.FillEllipse(brush, x, y, diameter, diameter);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawGoBoard(e.Graphics);
            Brush brush = Brushes.Black;
            int x1 = 210 - 10 / 2;
            int x2 = 490 - 10 / 2;
            int x3 = 350 - 10 / 2;

            DrawCircle(e.Graphics, brush, x1, x1, 10);
            DrawCircle(e.Graphics, brush, x2, x1, 10);
            DrawCircle(e.Graphics, brush, x3, x3, 10);
            DrawCircle(e.Graphics, brush, x1, x2, 10);
            DrawCircle(e.Graphics, brush, x2, x2, 10);
        }


        private void SetPositionToBroad(int x, int y, int z)
        {
            int xnew = x / 70;
            int ynew = y / 70;
            chessBroad.SetPosition(xnew, ynew, z);

        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            //trang la 2
            //den la 1



            if(!isTurn)
            {
                MessageBox.Show("Chưa đến lượt của bạn","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }    
            

            int toadox = ToaDoX(e.X);
            int toadoy = ToaDoY(e.Y);
            


            int circleSize = 32;
            int circleX = toadox - circleSize / 2;
            int circleY = toadoy - circleSize / 2;
            //MessageBox.Show(tableIndex+"");
            if (isBlack)
            {

                //SetPositionToBroad(toadox, toadoy, 1);
                service.SendToServer(string.Format("ChessInfo,{0},{1},{2},{3}", tableIndex,side,toadox,toadoy));

            }
            else
            {
                //SetPositionToBroad(toadox, toadoy, 2);
                service.SendToServer(string.Format("ChessInfo,{0},{1},{2},{3}", tableIndex, side, toadox, toadoy));

            }
           
        }

        public void rawChessPieces(int side, int x,int y,int anotherside)
        {

           

            //side 0 black 1 white
            int toadox = ToaDoX(x);
            int toadoy = ToaDoY(y);
            int circleSize = 32;
            int circleX = toadox - circleSize / 2;
            int circleY = toadoy - circleSize / 2;
            PictureBox pictureBox = new PictureBox();
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Size = new Size(circleSize, circleSize);
            pictureBox.Location = new Point(circleX, circleY);
            pictureBox.Paint += (s, args) =>
            {
                if (side==0)
                {
                    args.Graphics.FillEllipse(Brushes.Black, 0, 0, circleSize, circleSize);
                    SetPositionToBroad(toadox, toadoy, 1);

                }
                else
                {
                    args.Graphics.FillEllipse(Brushes.White, 0, 0, circleSize, circleSize);
                    SetPositionToBroad(toadox, toadoy, 2);
                }
            };



            panel1.Invoke(new MethodInvoker(() =>
            {
                panel1.Controls.Add(pictureBox);
            }));

            if(anotherside==this.side)
            {
                isTurn = true;
            }
            else
            {
                isTurn = false;
            }
            // panel1.Controls.Add(pictureBox);

            

          /*  if (CheckThePieceIsCaptured())
            {
                MessageBox.Show("Có quân bị ăn!");
            }
            else
            {
                //MessageBox.Show("Chưa có gì hết!");
            }*/


        }

        public bool CheckThePieceIsCaptured()
        {
            bool checkout = false;
            var listCapture = chessBroad.GetCapturedStones(out checkout);
            if (listCapture.Count > 0)
            {
                return true;
            }
            return false;
        }


        public void BeginGame()
        {
            panel1.Invoke(new MethodInvoker(() =>
            {
                this.panel1.Visible = true;
            }));
           
        }
        private int ToaDoX(int X)
        {
            int du = X % 70;
            if (du == 0)
            {
                return X;
            }
            else
            {
                int thuong = X / 70;
                int gocX = thuong * 70;
                if (X <= gocX + 35)
                {
                    return gocX;
                }
                else
                {
                    return gocX + 70;
                }

            }


        }
        private int ToaDoY(int Y)
        {
            int du = Y % 70;
            if (du == 0)
            {
                return Y;
            }
            else
            {
                int thuong = Y / 70;
                int gocY = thuong * 70;
                if (Y <= gocY + 35)
                {
                    return gocY;
                }
                else
                {
                    return gocY + 70;
                }
            }
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            service.SendToServer(string.Format("Start,{0},{1}", tableIndex, side));
            this.buttonReady.Enabled = false;

        }


        void RemovePictureBoxAtLocation(Panel panel, Point location)
        {
            // Duyệt qua tất cả các PictureBox trong Panel và kiểm tra tọa độ
            foreach (Control control in panel.Controls)
            {
                if (control is PictureBox pictureBox && pictureBox.Bounds.Contains(location))
                {
                    panel.Controls.Remove(pictureBox); // Xóa PictureBox nếu tọa độ nằm trong PictureBox
                    pictureBox.Dispose(); // Giải phóng tài nguyên
                    return; // Thoát sau khi xóa
                }
            }
        }
    }
}
