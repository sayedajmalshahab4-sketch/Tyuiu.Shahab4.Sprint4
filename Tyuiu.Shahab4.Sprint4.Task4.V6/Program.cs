using System;
using Tyuiu.Shahab4.Sprint4.Task4.V6.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task4.V6
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Шахаб А. | АСОиУБ-25-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 9. Заменить нечетные       *");
            Console.WriteLine("* элементы массива на 0.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];

            Console.WriteLine("Введите 25 элементов массива (числа от 4 до 9):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                    // Проверка диапазона
                    while (matrix[i, j] < 4 || matrix[i, j] > 9)
                    {
                        Console.WriteLine("Ошибка! Число должно быть от 4 до 9.");
                        Console.Write($"Элемент [{i},{j}]: ");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Исходный массив:");
            PrintMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            int[,] resultMatrix = ds.Calculate(matrix);

            Console.WriteLine("Массив после замены нечетных элементов на 0:");
            PrintMatrix(resultMatrix);

            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}