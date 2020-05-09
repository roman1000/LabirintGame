using System;


namespace LabirintGame
{
    class Program
    {
        static void Main()
        {
            Labirint();
        }
        static int height = 10;
        static int width = 12;
        static  int[,] LabirintLine = new int[height, width];
        static int DogX = 1;
        static int DogY = 1;
        static int Block = 28;
        static void Draw()
        {
             Console.Clear();
             for (int i = 0; i < LabirintLine.GetLength(0); i++)
             {
             for (int j = 0; j < LabirintLine.GetLength(1); j++)
             {
                 if (LabirintLine[i, j] > Block) Console.Write(".");
                 if (LabirintLine[i, j] < Block) Console.Write("#");
                 if (LabirintLine[i, j] == Block) Console.Write("F");
             }
             Console.WriteLine();
             }
            DogPlace();
        }
        static void DogPlace()
        {
             Console.CursorLeft = DogX;
             Console.CursorTop = DogY;
             Console.Write("@");
        }
        static void GeneratField()
        {
             Random RandomSizeOfMap = new Random();
             for (int Height = 0; Height < height; Height++)
             {
                 for (int Width = 0; Width < width; Width++)
                 {
                    LabirintLine[Height, Width] = RandomSizeOfMap.Next(0, 100);
                 }

            }
        }
        static void Logic()
        {
             ConsoleKeyInfo KeyDown = Console.ReadKey(true);
             if (KeyDown.Key == ConsoleKey.LeftArrow && LabirintLine[DogY, DogX - 1] >= Block) DogX--;
             if (KeyDown.Key == ConsoleKey.RightArrow && LabirintLine[DogY, DogX + 1] >= Block) DogX++;
             if (KeyDown.Key == ConsoleKey.UpArrow && LabirintLine[DogY - 1, DogX] >= Block) DogY--;
             if (KeyDown.Key == ConsoleKey.DownArrow && LabirintLine[DogY + 1, DogX] >= Block) DogY++;
             if (LabirintLine[DogY, DogX] == Block)
             {
                  Console.WriteLine("Win");
                  KeyDown = Console.ReadKey(false);
                  if (KeyDown.Key == ConsoleKey.LeftArrow && LabirintLine[DogY, DogX - 1] >= Block) DogX = DogX;
                  if (KeyDown.Key == ConsoleKey.RightArrow && LabirintLine[DogY, DogX + 1] >= Block) DogX = DogX;
                  if (KeyDown.Key == ConsoleKey.UpArrow && LabirintLine[DogY - 1, DogX] >= Block) DogY = DogY;
                  if (KeyDown.Key == ConsoleKey.DownArrow && LabirintLine[DogY + 1, DogX] >= Block) DogY = DogY;
            }

        }
        
        
        static void Labirint()
        {
            Console.CursorVisible = false;
            GeneratField();
            while (true)
            {
                Draw();
                Logic();
            }
        }
        


    }
}
