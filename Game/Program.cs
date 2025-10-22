using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        readonly static int fieldSize = 10;
        readonly static char[,] PlayerField = new char[fieldSize, fieldSize];

        static void Main(string[] args)
        {
            InitializateField(PlayerField);
            PrintField(PlayerField, "Уровень 1:");

            int cursorLeft = 5;
            int cursorTop = 5;            

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                
                switch (keyInfo.Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.ResetColor();
                        InitializateField(PlayerField);
                        PrintField(PlayerField, "Уровень 1:");
                        cursorLeft--;
                        Console.SetCursorPosition(cursorLeft, cursorTop);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("@");
                        break;

                    case ConsoleKey.S:
                        Console.Clear();
                        Console.ResetColor();
                        InitializateField(PlayerField);
                        PrintField(PlayerField, "Уровень 1:");
                        cursorLeft++;
                        Console.SetCursorPosition(cursorLeft, cursorTop);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("@");
                        break;

                    case ConsoleKey.W:
                        Console.Clear();
                        Console.ResetColor();
                        InitializateField(PlayerField);
                        PrintField(PlayerField, "Уровень 1:");
                        cursorTop--;
                        Console.SetCursorPosition(cursorLeft, cursorTop);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("@");
                        break;

                    case ConsoleKey.Z:
                        Console.Clear();
                        Console.ResetColor();
                        InitializateField(PlayerField);
                        PrintField(PlayerField, "Уровень 1:");
                        cursorTop++;
                        Console.SetCursorPosition(cursorLeft, cursorTop);
                        Console.ForegroundColor = ConsoleColor.Yellow;
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
        static void InitializateField(char[,] field)
        {
            for (int i = 0; i < fieldSize; ++i)
            {
                for (int j = 0; j < fieldSize; ++j)
                {
                    field[i, j] = '.';
                }
            }
        }
        static void PrintField(char[,] field, string level_name)
        {
            Console.WriteLine(level_name);
            Console.Write("  ");
            for (int i = 0; i < fieldSize; ++i)
            {
                Console.Write($"{(char)('-')} ");
            }
            Console.WriteLine();

            for (int i = 0; i < fieldSize; ++i)
            { 
              Console.Write($"{(char)('|')} ");
                                
                    for (int j = 0; j < fieldSize; ++j)
                    {
                        Console.Write($"{field[i, j]} ");
                    }
                
                Console.WriteLine();
            }
        }
    }
}

