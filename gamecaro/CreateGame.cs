using System;

namespace gamecaro
{
    public class CreateGame
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int HeightPlayed { get; set; }
        public int WidthPlayed { get; set; }
        public int[,] Table { get; set; }
        public char factor { get; set; }
        public int temp { get; set; }
        public int temp1 { get; set; }
        public int temp2 { get; set; }
        public int temp3 { get; set; }
        public int temp4 { get; set; }
        public int temp5 { get; set; }
        public int temp6 { get; set; }
        public int temp7 { get; set; }
        public int temp8 { get; set; }
        public int temp9 { get; set; }

        public void CreateNewTable()
        {
            Table = new int[Height, Width];
        }
        public void Start()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    //Tao stt cot

                    if (j == 0)
                    {
                        Console.Write(Convert.ToChar('A' + i));
                        Console.Write(' ');
                        Console.Write(' ');
                    }

                    // Tao bang game

                    if (Table[i, j] == 0)
                    {
                        if (i == HeightPlayed && j == WidthPlayed)
                        {
                            Console.Write(factor);
                            Table[HeightPlayed, WidthPlayed] = factor;
                        }
                        else Console.Write(' ');
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write(Convert.ToChar(Table[i, j]));
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }

            // Tao stt hang 
            for (int i = 0; i <= Height; i++)
            {
                if (i == 0)
                {
                    Console.Write(' ');
                    Console.Write(' ');
                }
                else
                    Console.Write(i);
                Console.Write(' ');
            }
            Console.WriteLine();
        }

        public Boolean IsWin()
        {
            for (int i = 0; i < Height - 1; i++)
            {
                // Check hang ngang 

                if (Table[HeightPlayed, i] == Table[HeightPlayed, i + 1] && Table[HeightPlayed, i] == 'x')
                {
                    temp += 1;
                    if (temp == 4)
                    {
                        Console.WriteLine("Player1 win");
                        break;
                    }
                }
                else
                {
                    temp = 0;
                }
                if (Table[HeightPlayed, i] == Table[HeightPlayed, i + 1] && Table[HeightPlayed, i] == 'o')
                {
                    temp1 += 1;
                    if (temp1 == 4)
                    {
                        Console.WriteLine("Player2 win");
                        break;
                    }
                }
                else
                {
                    temp1 = 0;
                }

                // Check hang doc

                if (Table[i, WidthPlayed] == Table[i + 1, WidthPlayed] && Table[i, WidthPlayed] == 'x')
                {
                    temp2 += 1;
                    if (temp2 == 4)
                    {
                        Console.WriteLine("Player1 win");
                        break;
                    }
                }
                else
                {
                    temp2 = 0;
                }
                if (Table[i, WidthPlayed] == Table[i + 1, WidthPlayed] && Table[i, WidthPlayed] == 'o')
                {
                    temp3 += 1;
                    if (temp3 == 4)
                    {
                        Console.WriteLine("Player2 win");
                        break;
                    }
                }
                else
                {
                    temp3 = 0;
                }
            }

            // Check cheo tren trai - duoi phai

            for (int i = -Math.Min(HeightPlayed, WidthPlayed); i < Height - 1 - Math.Max(HeightPlayed, WidthPlayed); i++)
            {

                if (Table[HeightPlayed + i, WidthPlayed + i] == Table[HeightPlayed + i + 1, WidthPlayed + i + 1] && Table[HeightPlayed + i, WidthPlayed + i] == 'x')
                {
                    temp4 += 1;
                    if (temp4 == 4)
                    {
                        Console.WriteLine("Player1 Win");
                        break;
                    }
                }
                else
                {
                    temp4 = 0;
                }
                if (Table[HeightPlayed + i, WidthPlayed + i] == Table[HeightPlayed + i + 1, WidthPlayed + i + 1] && Table[HeightPlayed + i, WidthPlayed + i] == 'o')
                {
                    temp5 += 1;
                    if (temp5 == 4)
                    {
                        Console.WriteLine("Player2 Win");
                        break;
                    }
                }
                else
                {
                    temp5 = 0;
                }
            }

            // Check cheo duoi trai - tren phai

            // 1/2 map o tren

            if ((HeightPlayed + WidthPlayed) < Height)
            {
                for (int i = -WidthPlayed; i < HeightPlayed; i++)
                {
                    if (Table[HeightPlayed - i, WidthPlayed + i] == Table[HeightPlayed - i - 1, WidthPlayed + i + 1] && Table[HeightPlayed - i, WidthPlayed + i] == 'x')
                    {
                        temp6 += 1;
                        if (temp6 == 4)
                        {
                            Console.WriteLine("Player1 Win");
                            break;
                        }
                    }
                    else
                    {
                        temp6 = 0;
                    }
                    if (Table[HeightPlayed - i, WidthPlayed + i] == Table[HeightPlayed - i - 1, WidthPlayed + i + 1] && Table[HeightPlayed - i, WidthPlayed + i] == 'o')
                    {
                        temp7 += 1;
                        if (temp7 == 4)
                        {
                            Console.WriteLine("Player2 Win");
                            break;
                        }
                    }
                    else
                    {
                        temp7 = 0;
                    }
                }
            }

            // 1/2 map o duoi


            if (HeightPlayed + WidthPlayed > Height)
            {
                for (int i = -(Height - 1 - HeightPlayed); i < (Height - 1 - WidthPlayed) - 1; i++)
                {
                    if (Table[HeightPlayed - i, WidthPlayed + i] == Table[HeightPlayed - i - 1, WidthPlayed + i + 1] && Table[HeightPlayed - i, WidthPlayed + i] == 'x')
                    {
                        temp8 += 1;
                        if (temp8 == 4)
                        {
                            Console.WriteLine("Player1 Win");
                            break;
                        }
                    }
                    else
                    {
                        temp8 = 0;
                    }
                    if (Table[HeightPlayed - i, WidthPlayed + i] == Table[HeightPlayed - i - 1, WidthPlayed + i + 1] && Table[HeightPlayed - i, WidthPlayed + i] == 'o')
                    {
                        temp9 += 1;
                        if (temp9 == 4)
                        {
                            Console.WriteLine("Player2 Win");
                            break;
                        }
                    }
                    else
                    {
                        temp9 = 0;
                    }
                }
            }
            if (temp == 4 || temp1 == 4 || temp2 == 4 || temp3 == 4 || temp4 == 4 || temp5 == 4 || temp6 == 4 || temp7 == 4 || temp8 == 4 || temp9 == 4)
                return true;
            return false;
        }
    }
}
