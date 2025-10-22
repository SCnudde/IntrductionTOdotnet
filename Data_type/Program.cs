using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тип данных в количестве байтах :");
            Console.WriteLine($@"{typeof(byte)}: {sizeof(byte)} байт");
            Console.WriteLine($@"{typeof(sbyte)}: {sizeof(sbyte)} байт");
            Console.WriteLine($@"{typeof(ushort)}: {sizeof(ushort)} байт");
            Console.WriteLine($@"{typeof(int)}: {sizeof(int)} байт");
            Console.WriteLine($@"{typeof(uint)}: {sizeof(uint)} байт");
            Console.WriteLine($@"{typeof(ulong)}: {sizeof(ulong)} байт");
            Console.WriteLine($@"{typeof(float)}: {sizeof(float)} байт");
            Console.WriteLine($@"{typeof(double)}: {sizeof(double)} байт");
            Console.WriteLine($@"{typeof(decimal)}: {sizeof(decimal)} байт");

            //Console.WriteLine($"Int "); sizeof(int);
        }

    }
}
