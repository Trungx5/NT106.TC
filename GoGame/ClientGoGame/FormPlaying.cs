using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace ClientGoGame
{
    public partial class FormPlaying : Form
    {
        private const int BoardSize = 10;
        private const int SquareSize = 70;
        private Service service;
        private ChessBroad chessBroad;
        private int tableIndex;
        private int side;
        private bool isTurn = false;
        private int numberOfPrisoner = 0;
        private double score = 0;
        private bool eventDelete = false;

        //check black or white
        private bool isBlack = false;
        /*  public FormPlaying()
          {
              InitializeComponent();
              InitializeGoBoard();
          }*/


        public FormPlaying(int TableIndex, int Side, StreamWriter sw)
        {
            chessBroad = new ChessBroad();
            InitializeComponent();

            this.tableIndex = TableIndex;
            this.side = Side;
            if (Side == 1)
            {
                labelSide.Text = "White";
                //labelName1.Text = name;
                pictureBox1.Image = Properties.Resources.quantrangnew;
                isBlack = false;
            }
            else
            {
                labelSide.Text = "Black";
                //labelName1.Text = name;
                pictureBox1.Image = Properties.Resources.quandennew;
                isBlack = true;
                isTurn = true;
            }
            service = new Service(listBox1, sw);
            InitializeGoBoard();
            //
            panel1.Visible = false;
            buttonSkip.Enabled = false;

        }



        private void InitializeGoBoard()
        {
            panel1.Width = panel1.Height = SquareSize * BoardSize;
            this.BackColor = Color.White;
            buttonSkip.Enabled = true;
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

        public void panel1_Paint(object sender, PaintEventArgs e)
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



            if (!isTurn)
            {
                MessageBox.Show("Chưa đến lượt của bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                //Display();
                SetPositionToBroad(toadox, toadoy, 1);
                var list1 = chessBroad.GetCapturedStones3(side);
                var list2 = chessBroad.GetCapturedStones2(side);
                if (list1.Count > 0 && list2.Count == 0)
                {
                    SetPositionToBroad(toadox, toadoy, 0);
                    MessageBox.Show("Không được đánh tại đây!");
                    return;
                }
                else
                {
                    SetPositionToBroad(toadox, toadoy, 0);
                    service.SendToServer(string.Format("ChessInfo,{0},{1},{2},{3}", tableIndex, side, toadox, toadoy));
                }

                //service.SendToServer(string.Format("ChessInfo,{0},{1},{2},{3}", tableIndex,side,toadox,toadoy));

            }
            else
            {
                //Display();
                //SetPositionToBroad(toadox, toadoy, 2);
                SetPositionToBroad(toadox, toadoy, 2);

                //Display();
                var list1 = chessBroad.GetCapturedStones3(side);
                var list2 = chessBroad.GetCapturedStones2(side);
                if (list1.Count > 0 && list2.Count == 0)
                {
                    SetPositionToBroad(toadox, toadoy, 0);
                    MessageBox.Show("Không được đánh tại đây!");
                    return;
                }
                else
                {
                    SetPositionToBroad(toadox, toadoy, 0);
                    service.SendToServer(string.Format("ChessInfo,{0},{1},{2},{3}", tableIndex, side, toadox, toadoy));
                }
                //service.SendToServer(string.Format("ChessInfo,{0},{1},{2},{3}", tableIndex, side, toadox, toadoy));

            }

        }

        public void rawChessPieces(int side, int x, int y, int anotherside)
        {

            eventDelete = false;
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
                if (side == 0)
                {
                    args.Graphics.FillEllipse(Brushes.Black, 0, 0, circleSize, circleSize);
                    //SetPositionToBroad(toadox, toadoy, 1);



                }
                else
                {
                    args.Graphics.FillEllipse(Brushes.White, 0, 0, circleSize, circleSize);
                    //SetPositionToBroad(toadox, toadoy, 2);


                }
            };

            if (side == 0)
            {
                SetPositionToBroad(toadox, toadoy, 1);

            }
            else
            {
                SetPositionToBroad(toadox, toadoy, 2);
            }

            if (panel1.InvokeRequired)
            {
                panel1.Invoke(new MethodInvoker(() =>
                {
                    panel1.Controls.Add(pictureBox);


                }));
            }


            List<(int, int)> listCapture = new List<(int, int)>();
            if (CheckThePieceIsCaptured(out listCapture) && isTurn == true)
            {

                //CO SK XOA

                eventDelete = true;
                string str = "";
                for (int i = 0; i < listCapture.Count; i++)
                {
                    if (i != listCapture.Count - 1)
                    {
                        str += listCapture[i].Item1 + "," + listCapture[i].Item2 + ",";
                    }
                    else
                    {
                        str += listCapture[i].Item1 + "," + listCapture[i].Item2;
                    }

                }


                //MessageBox.Show(str);
                service.SendToServer("PieceCapture" + "," + tableIndex + "," + str);


                // MessageBox.Show("PieceCapture" + "," + tableIndex +","+ str);
                // DrawAgainBroadAfterGo();

                //service.SendToServer(string.Format("PieceCapture"))

            }
            else
            {
                //MessageBox.Show("Chưa có gì hết!");
            }


            if (anotherside == this.side)
            {
                isTurn = true;
                if (buttonSkip.InvokeRequired)
                {
                    buttonSkip.Invoke(new MethodInvoker(() =>
                    {
                        buttonSkip.Enabled = true;
                    }));
                }

            }
            else
            {
                isTurn = false;
                if (buttonSkip.InvokeRequired)
                {
                    buttonSkip.Invoke(new MethodInvoker(() =>
                    {
                        buttonSkip.Enabled = false;
                    }));
                }
            }


            //Display();


            //KHONG CO SK XOA
            if (eventDelete == false)
            {
                //Display();

                if (this.side == 1)
                {
                    score = CalculateWhiteTerritory() + 6.5;
                    //MessageBox.Show("WHITE: " + score);
                    service.SendToServer(string.Format("Score,{0},{1},{2}", tableIndex, this.side, score));
                    if (labelScore1.InvokeRequired)
                    {
                        labelScore1.Invoke(new MethodInvoker(() =>
                        {
                            labelScore1.Text = "Score: " + score.ToString();
                        }));
                    }
                }
                else
                {
                    score = CalculateBlackTerritory();
                    //MessageBox.Show("BLACK: " + score);
                    service.SendToServer(string.Format("Score,{0},{1},{2}", tableIndex, this.side, score));
                    if (labelScore1.InvokeRequired)
                    {
                        labelScore1.Invoke(new MethodInvoker(() =>
                        {
                            labelScore1.Text = "Score: " + score.ToString();
                        }));
                    }
                }

                /* if (this.side == 1)
                 {
                     //white
                     this.score = CalculateWhiteTerritory();
                     //format Score,table index,otherside,score
                     int anothersidee = (side + 1) % 2;
                     service.SendToServer(string.Format("Score,{0},{1},{2}", tableIndex, anothersidee, score));
                     if (labelScore1.InvokeRequired)
                     {
                         labelScore1.Invoke(new MethodInvoker(() =>
                         {
                             labelScore1.Text = "Score: "+this.score.ToString();
                         }));
                     }

                 }
                 else
                 {
                     //black
                     this.score = CalculateBlackTerritory();
                     int anothersidee = (side + 1) % 2;
                     service.SendToServer(string.Format("Score,{0},{1},{2}", tableIndex, anothersidee, score));
                     if (labelScore1.InvokeRequired)
                     {
                         labelScore1.Invoke(new MethodInvoker(() =>
                         {
                             labelScore1.Text = "Score: " + this.score.ToString();
                         }));
                     }
                 }*/
                eventDelete = false;
            }


            /* List<(int, int)> listCapture = new List<(int, int)>(); 
             if (CheckThePieceIsCaptured(out listCapture)&&isTurn==false)
             {

                 string str = "";
                *//* foreach (var capture in listCapture)
                 {


                     str += capture.Item1 + "," + capture.Item2+",";
                 }*//*
                 for(int i=0; i<listCapture.Count;i++)
                 {
                     if (i != listCapture.Count - 1)
                     {
                         str += listCapture[i].Item1 + "," + listCapture[i].Item2 + ",";
                     }
                     else
                     {
                         str += listCapture[i].Item1 + "," + listCapture[i].Item2;
                     }

                 }


                 //MessageBox.Show(str);
                 service.SendToServer("PieceCapture"+","+tableIndex+","+str);


                // MessageBox.Show("PieceCapture" + "," + tableIndex +","+ str);
                 // DrawAgainBroadAfterGo();

                 //service.SendToServer(string.Format("PieceCapture"))

             }
             else
             {
                 //MessageBox.Show("Chưa có gì hết!");
             }
 */

        }

        public void Display()
        {
            chessBroad.Display();
        }

        public bool CheckThePieceIsCaptured(out List<(int, int)> listCapture)
        {

            listCapture = chessBroad.GetCapturedStones2(side);
            if (listCapture.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool CheckThePieceIsCaptured2(out List<(int, int)> listCapture)
        {
            int sidee = 0;
            if (side == 0)
            {
                sidee = 1;
            }
            else
            {
                sidee = 0;
            }
            listCapture = chessBroad.GetCapturedStones2(sidee);
            if (listCapture.Count > 0)
            {
                return true;
            }
            return false;
        }

        /* public bool CheckThePieceIsCaptured(out bool isBlack)
         {
             var listCapture = chessBroad.GetCapturedStones();
             if (listCapture.Count > 0)
             {

                 return true;
             }
             return false;
         }*/


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
                    if (panel.InvokeRequired)
                    {
                        panel.Invoke(new MethodInvoker(() =>
                        {
                            panel.Controls.Remove(pictureBox); // Xóa PictureBox nếu tọa độ nằm trong PictureBox
                            pictureBox.Dispose(); // Giải phóng tài nguyên
                            return; // Thoát sau khi xóa

                        }));
                    }


                }
            }
        }

        public void DrawAgainBroadAfterGo(List<(int, int)> listStone)
        {

            //var listStone = chessBroad.GetCapturedStones();
            int x = listStone[0].Item1;
            int y = listStone[0].Item2;
            int sideinfoo = -1;
            if (chessBroad.board[x, y] == 1)
            {
                //bi an
                sideinfoo = 0;
            }
            else
            {
                sideinfoo = 1;
            }


            int newnumber = listStone.Count;
            if (newnumber > 0)
            {
                if (side != sideinfoo)
                {
                    service.SendToServer(string.Format("NumberPrison,{0},{1},{2}", tableIndex, sideinfoo, newnumber));
                }
                //service.SendToServer(string.Format("NumberPrison,{0},{1},{2}",tableIndex,sideinfoo, newnumber));
                //MessageBox.Show(newnumber + "");
            }


            foreach (var item in listStone)
            {


                int toadox = (item.Item1 + 1) * 70;
                int toadoy = (item.Item2 + 1) * 70;

                RemovePictureBoxAtLocation(panel1, new Point(toadoy, toadox));
                chessBroad.SetPosition(item.Item2 + 1, item.Item1 + 1, 0);
            }

            //Display();

            if (this.side == 1)
            {
                score = CalculateWhiteTerritory() + 6.5;
                //MessageBox.Show("WHITE: " + score);
                service.SendToServer(string.Format("Score,{0},{1},{2}", tableIndex, this.side, score));
                if (labelScore1.InvokeRequired)
                {
                    labelScore1.Invoke(new MethodInvoker(() =>
                    {
                        labelScore1.Text = "Score: " + score.ToString();
                    }));
                }
            }
            else
            {
                score = CalculateBlackTerritory();
                //MessageBox.Show("BLACK: " + score);
                service.SendToServer(string.Format("Score,{0},{1},{2}", tableIndex, this.side, score));
                if (labelScore1.InvokeRequired)
                {
                    labelScore1.Invoke(new MethodInvoker(() =>
                    {
                        labelScore1.Text = "Score: " + score.ToString();
                    }));
                }
            }


            ////
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {

        }

        public void SetInfo(int sidee, string namee)
        {
            if (side == sidee)
            {
                if (labelName1.InvokeRequired)
                {
                    labelName1.Invoke(new MethodInvoker(() =>
                    {
                        labelName1.Text = namee;
                    }));
                }


            }
            else
            {

                if (labelName2.InvokeRequired)
                {
                    labelName2.Invoke(new MethodInvoker(() =>
                    {
                        labelName2.Text = namee;
                    }));
                }
                if (sidee == 1)
                {
                    if (pictureBox2.InvokeRequired)
                    {
                        pictureBox2.Invoke(new MethodInvoker(() =>
                        {
                            pictureBox2.Image = Properties.Resources.quantrangnew;
                        }));

                    }

                }
                else
                {
                    if (pictureBox2.InvokeRequired)
                    {
                        pictureBox2.Invoke(new MethodInvoker(() =>
                        {
                            pictureBox2.Image = Properties.Resources.quandennew;
                        }));

                    }
                }
            }
        }
        public void SetNumberPrison(int side, int number)
        {
            //MessageBox.Show(number + "");
            if (this.side != side)
            {
                numberOfPrisoner += number;
                if (labelPrisonser1.InvokeRequired)
                {
                    labelPrisonser1.Invoke(new MethodInvoker(() =>
                    {
                        this.labelPrisonser1.Text = numberOfPrisoner.ToString();
                    }));
                }

            }
            else
            {
                int friendNumberOfPrisoner = int.Parse(labelPrisonser2.Text);
                friendNumberOfPrisoner += number;
                if (labelPrisonser2.InvokeRequired)
                {
                    labelPrisonser2.Invoke(new MethodInvoker(() =>
                    {
                        this.labelPrisonser2.Text = friendNumberOfPrisoner.ToString();
                    }));
                }
            }
        }

        //Score White
        public double CalculateWhiteTerritory()
        {
            int territoryCount = 0;
            bool[,] visited = new bool[9, 9]; // Mark visited intersections

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (chessBroad.board[i, j] == 0 && !visited[i, j])
                    {
                        if (IsWhiteTerritory(i, j))
                        {
                            territoryCount++;
                        }
                    }
                }
            }

            return territoryCount;
        }
        public bool IsWhiteTerritory(int x, int y)
        {
            // Implement DFS or BFS to explore adjacent intersections
            // Here, let's assume a simple approach of DFS for illustration

            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
            HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();

            stack.Push(new Tuple<int, int>(x, y));

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                int i = current.Item1;
                int j = current.Item2;

                if (i < 0 || i >= 9 || j < 0 || j >= 9 || visited.Contains(current))
                    continue;

                visited.Add(current);

                if (chessBroad.board[i, j] == 1) // Black stone found, not white territory
                    return false;

                if (chessBroad.board[i, j] == 0) // Empty intersection
                {
                    // Add neighboring intersections to the stack
                    stack.Push(new Tuple<int, int>(i + 1, j));
                    stack.Push(new Tuple<int, int>(i - 1, j));
                    stack.Push(new Tuple<int, int>(i, j + 1));
                    stack.Push(new Tuple<int, int>(i, j - 1));
                }
            }

            // If all adjacent intersections are explored without encountering a black stone, it's white territory
            return true;
        }

        //Score Black
        public double CalculateBlackTerritory()
        {
            int territoryCount = 0;
            bool[,] visited = new bool[9, 9]; // Mark visited intersections

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (chessBroad.board[i, j] == 0 && !visited[i, j]) // Change condition to check for black pieces
                    {
                        if (IsBlackTerritory(i, j)) // Change method call to check for black territory
                        {
                            territoryCount++;
                        }
                    }
                }
            }

            return territoryCount;
        }


        public bool IsBlackTerritory(int x, int y)
        {
            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
            HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();

            stack.Push(new Tuple<int, int>(x, y));

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                int i = current.Item1;
                int j = current.Item2;

                if (i < 0 || i >= 9 || j < 0 || j >= 9 || visited.Contains(current))
                    continue;

                visited.Add(current);

                if (chessBroad.board[i, j] == 2) // White stone found, not black territory
                {
                    return false;
                }

                if (chessBroad.board[i, j] == 0) // Empty intersection
                {
                    // Add neighboring intersections to the stack
                    stack.Push(new Tuple<int, int>(i + 1, j));
                    stack.Push(new Tuple<int, int>(i - 1, j));
                    stack.Push(new Tuple<int, int>(i, j + 1));
                    stack.Push(new Tuple<int, int>(i, j - 1));
                }

            }

            // If all adjacent intersections are explored without encountering a white stone, it's black territory
            return true;
        }


        public void SetScore(double score)
        {
            if (labelScore2.InvokeRequired)
            {
                labelScore2.Invoke(new MethodInvoker(() =>
                {
                    this.labelScore2.Text = "Score: " + score.ToString();
                }));
            }

        }

        private void FormPlaying_Load(object sender, EventArgs e)
        {

        }
        public void StartTimer()
        {
            TimerPlayer1.Start();
            TimerPlayer1_Label.Text = "30";
            TimeP2_Label.Text = "30";
        }

        private void TimerPlayer1_Tick_1(object sender, EventArgs e)
        {
            // Update player 1 timer label
            // If timer reaches 0 , player 1 loses

            TimerPlayer1_Label.Text = (int.Parse(TimerPlayer1_Label.Text) - 1).ToString();
        }

        private void TimerPlayer2_Tick(object sender, EventArgs e)
        {
            TimerP2_Label.Text = (int.Parse(TimerP2_Label.Text) - 1).ToString();
        }

        private void EndTurn1()
        {
                // Reset player 1 timer back to 30 seconds , stop timer and start player 2 timer , update label
                TimerPlayer1.Stop();
                TimerPlayer2.Start();
                TimerPlayer2.Enabled = true;
                TimerPlayer1.Enabled = false;
        }
        private void EndTurn2() 
        {
                // Reset player 2 timer back to 30 seconds , stop timer and start player 1 timer , update label
                TimerPlayer2.Stop();
                TimerPlayer1.Start();
                TimerPlayer1.Enabled = true;
                TimerPlayer2.Enabled = false;
        }

    }
}
