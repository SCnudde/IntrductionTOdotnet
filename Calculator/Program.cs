using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Введите первое число: ");
                int.TryParse(Console.ReadLine(), out int num_1 );

                Console.WriteLine("Введите второе число: ");
                int.TryParse(Console.ReadLine(), out int num_2);

                Console.WriteLine("Введите арифметическое действие: + - * / : ");
                string sign = Console.ReadLine();
               
                int result;
                switch (sign)
                { 
                    case "+":
                        Console.WriteLine($"Cумма чисел : { result = num_1 + num_2} ");
                        break;
                    case "-": 
                        Console.WriteLine($"Разность чисел : {result = num_1 - num_2} ");
                        break;
                    case "*":
                        Console.WriteLine($"Произведение чисел : {result = num_1 * num_2} ");
                        break;
                    case "/":
                        try
                        {
                          Console.WriteLine($"Деление чисел : {result = num_1 / num_2} ");
                        }
                        catch(DivideByZeroException)
                        {
                          Console.WriteLine("Деление на 0 не возможно!");
                        }                                       
                        break;                      
                }
                Console.WriteLine("При выходе наберите - esc: ");
                input = Console.ReadLine();

            } while(input !="esc");



        }
    }
}
