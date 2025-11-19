using System;
using Tyuiu.Shahab4.Sprint4.Task3.V30.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task3.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Шахаб А. | АСОиУБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Шахаб А. | АСОиУБ-25-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 6. Найдите максимальный     *");
            Console.WriteLine("* элемент в третьей строке массива.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5] {
                { 2, 4, 3, 5, 1 },
                { 6, 6, 1, 2, 6 },
                { 3, 3, 2, 1, 5 },
                { 6, 4, 1, 3, 3 },
                { 5, 1, 1, 6, 4 }
            };

            Console.WriteLine("Массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(matrix);
            Console.WriteLine($"Максимальный элемент в третьей строке = {result}");

            Console.ReadKey();
        }
    }
}