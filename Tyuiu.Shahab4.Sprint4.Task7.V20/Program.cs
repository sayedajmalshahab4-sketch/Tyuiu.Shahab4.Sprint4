using System;
using Tyuiu.Shahab4.Sprint4.Task7.V20.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task7.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string str = "357951248632587";

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine($"Строка: {str}");
            Console.WriteLine($"Длина строки: {str.Length}");

            
            Console.WriteLine("\nМатрица 5x3:");
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{str[index]} ");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                             *");
            Console.WriteLine("***********************************************************");

            int result = ds.Calculate(str);
            Console.WriteLine($"Произведение четных чисел = {result}");

            Console.WriteLine("***********************************************************");
            Console.ReadKey();
        }
    }
}