using System;

namespace gamecaro
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            var game = new CreateGame();
            game.Height = 10;
            game.Width = 10;
            game.CreateNewTable();
            game.Start();
            while (true)
            {
                if (i % 2 == 0)
                {
                    Console.Write("Player1: ");
                    game.factor = 'x';
                }
                else
                {
                    Console.Write("Player2: ");
                    game.factor = 'o';
                }
                var toado = Console.ReadLine();
                if (toado == "x")
                    break;
                else
                {
                    game.HeightPlayed = toado[0] - 65;
                    game.WidthPlayed = Convert.ToInt16(toado.Substring(1)) - 1;
                    game.Start();
                }
                i++;
                if (game.IsWin() == true)
                    break;
            }
        }
    }
}
