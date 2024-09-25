using System;
using System.Threading;
namespace rajz {
  class Program
{
    static void Main()
    {
        rajz rajzolas = new rajz();
        rajzolas.Start();
    }
}
internal class rajz
{
    public void Start()
    {
        Console.CursorVisible = false;
        int x = Console.WindowWidth / 2;
        int y = Console.WindowHeight / 2;
        ConsoleColor currentColor = ConsoleColor.White;

        
        Console.SetCursorPosition(x, y);
        Console.Write("█");

        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;

                
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (x > 0) x--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < Console.WindowWidth - 1) x++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > 0) y--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (y < Console.WindowHeight - 1) y++;
                        break;
                }

                switch (key)
                {
                    case ConsoleKey.D1:
                        currentColor = ConsoleColor.Red;
                        break;
                    case ConsoleKey.D2:
                        currentColor = ConsoleColor.Green;
                        break;
                    case ConsoleKey.D3:
                        currentColor = ConsoleColor.Blue;
                        break;
                    case ConsoleKey.D4:
                        currentColor = ConsoleColor.Yellow;
                        break;
                    case ConsoleKey.D5:
                        currentColor = ConsoleColor.Cyan;
                        break;
                    case ConsoleKey.D6:
                        currentColor = ConsoleColor.Magenta;
                        break;
                    case ConsoleKey.D7:
                        currentColor = ConsoleColor.White;
                        break;
                    case ConsoleKey.Escape:
                        return;
                         default;
                        break;
                }

                
                if (key == ConsoleKey.Spacebar)
                {
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = currentColor;
                    Console.Write("█");
                }

                Console.SetCursorPosition(x, y);
            }

        }
    }
}
}
