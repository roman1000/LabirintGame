using System;


namespace LabirintGame
{
    class Program
    {
        static void Main()
        {
            Labirint();

        }
        static void Labirint()
        {
            Console.CursorVisible = false;
            int[,] LabirintLine = new int[29,110];
            Random RandomSizeOfMap = new Random();
            for (int Height = 0; Height < 29; Height++)
            {
                for (int Width = 0; Width < 110; Width++)
                {
                    LabirintLine[Height, Width] = RandomSizeOfMap.Next(-1, 10);
                }

            }
                
                    


            int x = 1;
            int y = 1;
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < LabirintLine.GetLength(0); i++)
                {
                for (int i2 = 0; i2 < LabirintLine.GetLength(1); i2++)
                {
                    if (LabirintLine[i, i2] <= 8) Console.Write(" ");
                    if (LabirintLine[i, i2] > 8) Console.Write("#");

                }
                Console.WriteLine();
                }
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write("@");

                ConsoleKeyInfo KeyDown = Console.ReadKey(true);
                if (KeyDown.Key == ConsoleKey.Escape) break;
                if (KeyDown.Key == ConsoleKey.LeftArrow && LabirintLine[y, x - 1] <= 8) x--;
                if (KeyDown.Key == ConsoleKey.RightArrow && LabirintLine[y, x + 1] <= 8) x++;
                if (KeyDown.Key == ConsoleKey.UpArrow && LabirintLine[y - 1, x] <= 8) y--;
                if (KeyDown.Key == ConsoleKey.DownArrow && LabirintLine[y + 1, x] <= 8) y++;
            }
        }
        


    }
}
