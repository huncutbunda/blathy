using System;

class Program
{
            static int cursorX = 1;
        static int cursorY = 1;
        static ConsoleColor currentColor = ConsoleColor.White;

        static void Main()
        {
            DrawFrame();

            ConsoleKeyInfo keyInfo;

            while (true)
            {
                Console.SetCursorPosition(0, Console.WindowHeight - 5);
                Console.WriteLine("Használja a nyilakat a kurzor mozgatásához.");
                Console.WriteLine("Nyomja meg a SPACE-t a színezéshez.");
                Console.WriteLine("Számgombok a szín váltásához (0-9).");
                Console.WriteLine($"Aktuális szín: {currentColor}");
                
                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (cursorY > 1) cursorY--; break;
                    case ConsoleKey.DownArrow: if (cursorY < Console.WindowHeight - 2) cursorY++; break;
                    case ConsoleKey.LeftArrow: if (cursorX > 1) cursorX--; break;
                    case ConsoleKey.RightArrow: if (cursorX < Console.WindowWidth - 2) cursorX++; break;

                        
                    case ConsoleKey.Spacebar: ColorCurrentPosition(currentColor); break;
                    case ConsoleKey.D1: currentColor = ConsoleColor.Red; break;
                    case ConsoleKey.D2: currentColor = ConsoleColor.Blue; break;
                    case ConsoleKey.D3: currentColor = ConsoleColor.Green; break;
                    case ConsoleKey.D4: currentColor = ConsoleColor.Yellow; break;
                    case ConsoleKey.D5: currentColor = ConsoleColor.Cyan; break;
                }

                
            }
        }

        static void DrawFrame()
        {
            Console.Clear();
            


            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("═");
            }


            for (int i = 1; i < Console.WindowHeight - 1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("║");
                Console.SetCursorPosition(Console.WindowWidth - 1, i);
                Console.Write("║");
            }


            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, Console.WindowHeight - 1);
                Console.Write("═");
            }

            Console.ResetColor();
        }


        static void ColorCurrentPosition(ConsoleColor color)
        {
            Console.SetCursorPosition(cursorX, cursorY);
            Console.BackgroundColor = color;
            Console.Write(" ");
            Console.ResetColor();
        }


    }
}
