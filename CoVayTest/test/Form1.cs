using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private bool checkblack = true;
        private const int BoardSize = 10;
        private const int SquareSize = 70;
        private bool paint = true;

        private AnCo anCo=new AnCo();
        public Form1()
        {
            InitializeComponent();
           
            var taphoptoado=GetIntersectionPoints(SquareSize, BoardSize);
            Console.WriteLine("-----------------------");
            foreach (var point in taphoptoado)
            {
                Console.WriteLine(point.ToString());
            }    
            InitializeGoBoard();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            /*int circleSize = 50; // Kích thước của hình tròn
            int circleX = e.X - circleSize / 2; // Tọa độ X của hình tròn
            int circleY = e.Y - circleSize / 2; // Tọa độ Y của hình tròn

            // Vẽ hình tròn lên PictureBox
            PictureBox pictureBox = new PictureBox();
            pictureBox.BackColor = Color.Transparent; // Đặt nền của PictureBox là trong suốt
            pictureBox.Size = new Size(circleSize, circleSize);
            pictureBox.Location = new Point(circleX, circleY);
            pictureBox.Paint += (s, args) =>
            {
                args.Graphics.FillEllipse(Brushes.Red, 0, 0, circleSize, circleSize);
            };

            // Thêm PictureBox vào Form
            this.Controls.Add(pictureBox);*/
        }
        private void InitializeGoBoard()
        {
            panel1.Width = panel1.Height = SquareSize * BoardSize;
            this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            //DrawGoBoard(e.Graphics);
        }

        private void DrawGoBoard(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            for (int i = 0; i < BoardSize-1; i++)
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

        private List<Point> GetIntersectionPoints(int squareSize, int boardSize)
        {
            List<Point> intersectionPoints = new List<Point>();

            for (int i = 0; i < boardSize-1; i++)
            {
                for (int j = 0; j < boardSize-1; j++)
                {
                    intersectionPoints.Add(new Point((j + 1) * squareSize, (i + 1) * squareSize));
                }
            }

            return intersectionPoints;
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



        private void SetPositionToBroad(int x,int y,int z)
        {
            int xnew = x / 70;
            int ynew = y / 70;
            anCo.SetPosition(xnew, ynew,z);

        }



        //test
        private void panel1_MouseClick2(object sender, MouseEventArgs e)
        {

            //trang la 2
            //den la 1
            int toadox=ToaDoX(e.X);
            int toadoy = ToaDoY(e.Y);
      

            int circleSize = 32;
            int circleX = toadox - circleSize / 2;
            int circleY = toadoy - circleSize / 2;
            if (checkblack)
            {

                SetPositionToBroad(toadox, toadoy, 1);
                
                
            }
            else
            {
                SetPositionToBroad(toadox, toadoy, 2);
               

            }
           
            //bool checkblackout = false;

            List<bool> anco=new List<bool>();
            bool checkblackout = false;
            bool anhailoai = false;

            var listStoneCapture = anCo.GetCapturedStones2(ref anco);

             

             if(!anco.Contains(true))
            {
                checkblackout = false;
            }
            else if(!anco.Contains(false))
            {
                checkblackout = true;
            }
            else
            {
                anhailoai=true;
            }
               

            if (listStoneCapture.Count <= 0)
            {
                Console.WriteLine("vao day");
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Transparent;
                pictureBox.Size = new Size(circleSize, circleSize);
                pictureBox.Location = new Point(circleX, circleY);
                pictureBox.Paint += (s, args) =>
                {
                    if (checkblack)
                    {
                        args.Graphics.FillEllipse(Brushes.Black, 0, 0, circleSize, circleSize);
                        checkblack = false;
                       

                    }
                    else
                    {
                        args.Graphics.FillEllipse(Brushes.White, 0, 0, circleSize, circleSize);
                        checkblack = true;
                    }
                };

                panel1.Controls.Add(pictureBox);


            }

            else if(listStoneCapture.Count>0)
            {
                if(anhailoai==false)
                {
                    Console.WriteLine("vao else");
                    if (checkblack == checkblackout)
                    {
                        MessageBox.Show("Không thể đánh ở đây!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SetPositionToBroad(toadox, toadoy, 0);
                    }
                    else
                    {
                        DrawAgainBroadAfterGo();

                        //
                        if (checkblack)
                        {

                            SetPositionToBroad(toadox, toadoy, 1);


                        }
                        else
                        {
                            SetPositionToBroad(toadox, toadoy, 2);


                        }
                        //
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.BackColor = Color.Transparent;
                        pictureBox.Size = new Size(circleSize, circleSize);
                        pictureBox.Location = new Point(circleX, circleY);
                        pictureBox.Paint += (s, args) =>
                        {
                            if (checkblack)
                            {
                                args.Graphics.FillEllipse(Brushes.Black, 0, 0, circleSize, circleSize);
                                checkblack = false;

                            }
                            else
                            {
                                args.Graphics.FillEllipse(Brushes.White, 0, 0, circleSize, circleSize);
                                checkblack = true;
                            }
                        };

                        panel1.Controls.Add(pictureBox);


                    }
                }
                else
                {

                    //MessageBox.Show("An hai loai");
                    DrawAgainBroadAfterGo2(checkblack);
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.BackColor = Color.Transparent;
                    pictureBox.Size = new Size(circleSize, circleSize);
                    pictureBox.Location = new Point(circleX, circleY);
                    pictureBox.Paint += (s, args) =>
                    {
                        if (checkblack)
                        {
                            args.Graphics.FillEllipse(Brushes.Black, 0, 0, circleSize, circleSize);
                            checkblack = false;

                        }
                        else
                        {
                            args.Graphics.FillEllipse(Brushes.White, 0, 0, circleSize, circleSize);
                            checkblack = true;
                        }
                    };

                    panel1.Controls.Add(pictureBox);



                }


            }


        }


        /*private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

            int currentNumberOfWhite = anCo.GetNumberOfWhiteOnBroad();
            int currentNumberOfBlack = anCo.GetNumberOfBlackOnBroad();
            //Console.WriteLine("Truoc trang: "+currentNumberOfWhite);
            //Console.WriteLine("Truoc den: " + currentNumberOfBlack);
            anCo.HienThi();
            int toadox = ToaDoX(e.X);
            int toadoy=ToaDoY(e.Y);

            //MessageBox.Show(toadox.ToString()+" "+toadoy.ToString());

            int circleSize = 32; 
            // Kích thước của hình tròn
            // int circleX = e.X - circleSize / 2; // Tọa độ X của hình tròn
            // int circleY = e.Y - circleSize / 2; // Tọa độ Y của hình tròn
            int circleX = toadox - circleSize / 2;
            int circleY = toadoy - circleSize / 2;

           

            // Vẽ hình tròn lên PictureBox
            PictureBox pictureBox = new PictureBox();
            pictureBox.BackColor = Color.Transparent; // Đặt nền của PictureBox là trong suốt
            pictureBox.Size = new Size(circleSize, circleSize);

            
            pictureBox.Location = new Point(circleX, circleY);

            
            pictureBox.Paint += (s, args) =>
            {
                if (checkblack)
                {

                    //args.Graphics.FillEllipse(Brushes.White, 0, 0, circleSize, circleSize);
                    SetPositionToBroad(toadox, toadoy, 1);

                    //MessageBox.Show(currentNumberOfWhite.ToString());
                    //anCo.HienThi();

                    DrawAgainBroadAfterGo();
                    anCo.HienThi();




                    if (anCo.GetNumberOfWhiteOnBroad() <= currentNumberOfWhite)
                    {
                        MessageBox.Show("Không thể đánh ở đây!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checkblack = true;

                        return;

                    }
                    else
                    {
                        args.Graphics.FillEllipse(Brushes.White, 0, 0, circleSize, circleSize);

                        checkblack = false;

                        //panel1.Controls.Add(pictureBox);
                    }






                }
                else
                {

                    //args.Graphics.FillEllipse(Brushes.Black, 0, 0, circleSize, circleSize);
                    SetPositionToBroad(toadox, toadoy, 2);
                    //MessageBox.Show(currentNumberOfWhite.ToString());
                    //anCo.HienThi();

                    DrawAgainBroadAfterGo();
                    anCo.HienThi();


                    if (anCo.GetNumberOfBlackOnBroad() <= currentNumberOfBlack)
                    {
                        MessageBox.Show("Không thể đánh ở đây!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checkblack = false;

                        return;
                    }
                    else
                    {
                        args.Graphics.FillEllipse(Brushes.Black, 0, 0, circleSize, circleSize);

                        checkblack = true;

                        //panel1.Controls.Add(pictureBox);
                    }


                    //checkblack = true;
                }
            };

            // Thêm PictureBox vào Form


            panel1.Controls.Add(pictureBox);

            


        }*/

        private int ToaDoX(int X)
        {
            int  du = X % 70;
            if(du==0)
            {
                return X;
            }
            else
            {
                int thuong = X / 70;
                int gocX =thuong*70;
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
                int gocY= thuong * 70;
                if (Y<= gocY + 35)
                {
                    return gocY;
                }
                else
                {
                    return gocY + 70;
                }
            }
        }


        private void DrawAgainBroadAfterGo()
        {
            bool checkblack = false;
            var listStone = anCo.GetCapturedStones(out checkblack);
            foreach (var item in listStone)
            {
                Console.WriteLine("Duoc goi");
                

                int toadox = (item.Item1 + 1) * 70;
                int toadoy = (item.Item2 + 1) * 70;

                RemovePictureBoxAtLocation(panel1, new Point(toadoy,toadox));
                anCo.SetPosition(item.Item2+1, item.Item1+1, 0);
            }
        }

        private void DrawAgainBroadAfterGo2(bool checkblackcurrent)
        {
          
            bool checkblack = false;
            var listStone = anCo.GetCapturedStones(out checkblack);

            if(checkblackcurrent)
            {
                foreach (var item in listStone)
                {

                    if (anCo.board[item.Item1,item.Item2]!=1)
                    {
                        int toadox = (item.Item1 + 1) * 70;
                        int toadoy = (item.Item2 + 1) * 70;

                        RemovePictureBoxAtLocation(panel1, new Point(toadoy, toadox));
                        anCo.SetPosition(item.Item2 + 1, item.Item1 + 1, 0);
                    }    


                   
                }
            }
            else
            {
                foreach (var item in listStone)
                {

                    if (anCo.board[item.Item1, item.Item2] != 2)
                    {
                        int toadox = (item.Item1 + 1) * 70;
                        int toadoy = (item.Item2 + 1) * 70;

                        RemovePictureBoxAtLocation(panel1, new Point(toadoy, toadox));
                        anCo.SetPosition(item.Item2 + 1, item.Item1 + 1, 0);
                    }



                }
            }

          /*  foreach (var item in listStone)
            {

                Console.WriteLine("Duoc goi");


                int toadox = (item.Item1 + 1) * 70;
                int toadoy = (item.Item2 + 1) * 70;

                RemovePictureBoxAtLocation(panel1, new Point(toadoy, toadox));
                anCo.SetPosition(item.Item2 + 1, item.Item1 + 1, 0);
            }*/
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
