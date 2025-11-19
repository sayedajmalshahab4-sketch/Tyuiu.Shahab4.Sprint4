using System;
using Tyuiu.Shahab4.Sprint4.Task5.V18.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task5.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random random = new Random();

            Console.Title = "Спринт #4 | Выполнил: Шахаб А. | АСОиУБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Шахаб А. | АСОиУБ-25-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -6 до 7. Заменить отрицательные   *");
            Console.WriteLine("* элементы на 0.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];

            Console.WriteLine("Исходный массив (случайные числа от -6 до 7):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(-6, 8);
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            int[,] resultMatrix = ds.Calculate(matrix);

            Console.WriteLine("Массив после замены отрицательных элементов на 0:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{resultMatrix[i, j],3} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}