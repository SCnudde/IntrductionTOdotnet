#define ARRAY1
#if true
#define ARRAY_JAGGED
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//int[] arr = { 1, 2, 3, 4, 5 };
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

#endif
//Random random = new Random(0);  //Seed
//Console.Write("Enter a number:");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] arr2 = new int[n];
//for (int i = 0; i < arr2.Length; i++)
//{
//    arr2[i] = random.Next(100);
//}

//foreach (int item in arr2)
//{
//    arr2[item] = random.Next(50, 100);
//}

//for (int i = 0; i < arr2.Length; i++)
//{
//    Console.WriteLine(arr2[i] + "\t");
//}
//Console.WriteLine($"Average {arr2.Average()}");


//Многомерные массивы

//Console.WriteLine("Enter a number of rows");
//int rows = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter a number of cols");
//int cols = Convert.ToInt32(Console.ReadLine());

//int [,]arr3 = new int [rows, cols];
//Console.WriteLine($"Количество измерений: {arr3.Rank} ");

//for(int i = 0;i < arr3.GetLength(0);i++)
//    for (int j = 0;j < arr3.GetLength(1);j++)
//    {
//        arr3[i, j] = random.Next(100);
//    }

//for (int i = 0; i < arr3.GetLength(0); i++)
//{
//    for (int j = 0; j < arr3.GetLength(1); j++)
//    {
//        Console.Write($"{arr3[i, j]} \t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();

//Console.WriteLine($"Сумма элементов массива: {arr3.Cast<int>().Sum()}");
//Console.WriteLine($"Среднее арифмет элементов массива: {arr3.Cast<int>().Average()}");
//Console.WriteLine($"Мин элементов массива: {arr3.Cast<int>().Min()}");
//Console.WriteLine($"Макс элементов массива: {arr3.Cast<int>().Max()}");

int[][] arr4 =
{
    new int[]{0,1, 2, 3, 7},
    new int[]{3,4,5},
    new int[]{4,5}
};

for (int i = 0; i < arr4.Length; i++)
{
    for (int j = 0; j < arr4[i].Length; j++)
    {
        Console.Write(arr4[i][j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("---------------------------");

foreach (int[] i in arr4) //квадратные скобки
{    
    foreach (int j in i)
    {
        Console.Write(j + " \t");
    }
    Console.WriteLine();
}

Console.WriteLine();