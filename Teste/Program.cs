using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Program
    {
        static int fieldSize = 10;
        static char[,] PlayerField = new char[fieldSize, fieldSize];
        
        static void Main(string[] args)
        {

            InitializateField(PlayerField);
         

            PrintField(PlayerField, "Уровень 1:");

        }

        
        static void InitializateField(char[,] field)
        {
            for (int i = 0; i < fieldSize; ++i)
            {
                for (int j = 0; j < fieldSize; ++j)
                {
                    field[i, j] = '*';
                }
            }
        }
        static void PrintField(char[,] field, string level_name)
        {
            Console.WriteLine(level_name);
            Console.Write("  ");
            for (int i = 0; i < fieldSize; ++i)
            {
                Console.Write($"{i + 1} ");
            }
            Console.WriteLine();

            for (int i = 0; i < fieldSize; ++i)
            {
                Console.Write($"{(char)('A' + i)} ");
                for (int j = 0; j < fieldSize; ++j)
                {
                    Console.Write($"{field[i, j]} ");
                }
                Console.WriteLine();
            }
        }



    }
}
