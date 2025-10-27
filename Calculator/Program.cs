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
                double[] array = new double[] { };

                Console.WriteLine("Введите числа: ");

                input = Console.ReadLine();

                string[] input_2 = input.Split(' ');

                array = new double[input_2.Length];

                for (int i = 0; i < input_2.Length; i++)
                {
                    array[i] = Convert.ToDouble(input_2[i]);
                }

                Console.WriteLine("Введите арифметическое действие: + - * / : ");
                string sign = Console.ReadLine();

                double result = array[0];

                switch (sign)
                {
                    case "+":
                        for (int j = 1; j < array.Length; j++)
                        {
                            result += array[j];
                        }
                        Console.WriteLine($"Cумма чисел : {result} ");
                        break;

                    case "-":
                        for (int j = 1; j < array.Length; j++)
                        {
                            result -= array[j];
                        }
                        Console.WriteLine($"Разность чисел : {result} ");
                        break;

                    case "*":
                        for (int j = 1; j < array.Length; j++)
                        {
                            result *= array[j];
                        }
                        Console.WriteLine($"Произведение чисел : {result} ");
                        break;

                    case "/":
                        try
                        {
                            for (int j = 1; j < array.Length; j++)
                            {
                                result /= array[j];
                            }
                            Console.WriteLine($"Деление чисел : {result } ");
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Деление на 0 не возможно!");
                        }
                        break;
                }

                    Console.WriteLine("При выходе наберите - esc: ");
                    input = Console.ReadLine();                

            } while (input != "esc");
        }
    }
}
