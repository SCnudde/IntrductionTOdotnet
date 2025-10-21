using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int cursorLeft = 0;
            int cursorTop = 0;

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        cursorLeft--;
                        Console.SetCursorPosition(cursorLeft, cursorTop);
                        Console.Write("@");
                        break;

                    case ConsoleKey.S:
                        Console.Clear();
                        cursorLeft++;
                        Console.SetCursorPosition(cursorLeft, cursorTop);
                        Console.Write("@");
                        break;

                    case ConsoleKey.W:
                        Console.Clear();
                        cursorTop--;
                        Console.SetCursorPosition(cursorLeft, cursorTop);
                        Console.Write("@");
                        break;

                    case ConsoleKey.Z:
                        Console.Clear();
                        cursorTop++;
                        Console.SetCursorPosition(cursorLeft, cursorTop);
                        Console.Write("@");
                        break;

                    default:
                        string input = "";
                        input += keyInfo.KeyChar;
                        Console.Write(input);
                        break;
                }
            }
        }
    }
}
