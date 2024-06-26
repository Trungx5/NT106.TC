﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public  class AnCo
    {

        public int[,] board = new int[,] {
            {0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0}
        };

        public int numberOfWhiteOnBroad = 0;
        public int numberOfBlackOnBroad = 0;


        public int  GetNumberOfWhiteOnBroad()
        {
            int numberOfWhite = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i,j]==1)
                    {
                        numberOfWhite++;
                    }    
                   
                }
                
            }
            return numberOfWhite;
            
        }

        public int GetNumberOfBlackOnBroad()
        {
            int numberOfBlack = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] == 2)
                    {
                        numberOfBlack++;
                    }

                }

            }
            return numberOfBlack;

        }
        public void HienThi()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");
        }


        public void SetPosition(int x, int y,int z)
        {
            if(x>=1&& y>=1&&x<=9&&y<=9)
            {
                board[y-1, x-1] = z;
                
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");

        }







        public  bool IsStoneCaptured(/*int[,] board,*/ int row, int col)
        {
            int stoneColor = board[row, col];
            int size = board.GetLength(0);
            bool[,] visited = new bool[size, size];

            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((row, col));
            visited[row, col] = true;

            List<(int, int)> connectedStones = new List<(int, int)>();

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                int r = current.Item1;
                int c = current.Item2;

                connectedStones.Add((r, c));

                int[] dr = { -1, 1, 0, 0 };
                int[] dc = { 0, 0, -1, 1 };

                for (int i = 0; i < 4; i++)
                {
                    int nr = r + dr[i];
                    int nc = c + dc[i];

                    if (nr >= 0 && nr < size && nc >= 0 && nc < size && !visited[nr, nc])
                    {
                        if (board[nr, nc] == 0)
                        {
                            return false; // Stone has freedom, it's not captured
                        }
                        else if (board[nr, nc] == stoneColor)
                        {
                            queue.Enqueue((nr, nc));
                            visited[nr, nc] = true;
                        }
                    }
                }
            }

            // Check if all connected stones have no liberty
            foreach (var stone in connectedStones)
            {
                int r = stone.Item1;
                int c = stone.Item2;

                int[] dr = { -1, 1, 0, 0 };
                int[] dc = { 0, 0, -1, 1 };

                for (int i = 0; i < 4; i++)
                {
                    int nr = r + dr[i];
                    int nc = c + dc[i];

                    if (nr >= 0 && nr < size && nc >= 0 && nc < size && board[nr, nc] == 0)
                    {
                        return false; // At least one liberty exists, stone is not captured
                    }
                }
            }

            return true; // All connected stones have no liberty, they are captured
        }


        public  List<(int, int)> GetCapturedStones(out bool checkblack)
        {

            bool checkBlack = false;
            List<(int, int)> capturedStones = new List<(int, int)>();
            int size = board.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    
                    if (board[i, j] != 0 && IsStoneCaptured(i, j))
                    {
                        if (board[i,j]==1)
                        {
                            checkBlack = true;
                        }
                        else
                        {
                            checkBlack = false;
                        }
                        capturedStones.Add((i, j));
                    }
                }
            }
            checkblack = checkBlack;






            return capturedStones;
        }

        public List<(int, int)> GetCapturedStones2(ref List<bool> anco)
        {

            //bool checkBlack = false;
            anco = new List<bool>();
            List<(int, int)> capturedStones = new List<(int, int)>();
            int size = board.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    if (board[i, j] != 0 && IsStoneCaptured(i, j))
                    {
                        if (board[i, j] == 1)
                        {
                            //checkBlack = true;
                            anco.Add(true);
                        }
                        else
                        {
                            //checkBlack = false;
                            anco.Add(false);
                        }
                        capturedStones.Add((i, j));
                    }
                }
            }
            



            return capturedStones;
        }
    }
}
