using System;
using Tyuiu.Shahab4.Sprint4.Task7.V20.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task7.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шахаб А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка строковых данных                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Шахаб А. | СМАРТб-23-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '357951248632587'. Преобразуйте ее в  *");
            Console.WriteLine("* матрицу 5 на 3 и подсчитайте произведение четных чисел.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "357951248632587";
            Console.WriteLine($"Исходная строка: {str}");
            Console.WriteLine($"Длина строки: {str.Length} символов");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            try
            {
                // Получаем матрицу
                int[,] matrix = ds.GetMatrix(str);

                // Выводим матрицу
                Console.WriteLine("Матрица 5x3:");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Строка {0}: ", i + 1);
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                // Находим и выводим четные числа
                Console.Write("Четные числа в матрице: ");
                int product = 1;
                bool firstNumber = true;

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix[i, j] % 2 == 0)
                        {
                            if (!firstNumber)
                            {
                                Console.Write(" × ");
                            }
                            Console.Write(matrix[i, j]);
                            product *= matrix[i, j];
                            firstNumber = false;
                        }
                    }
                }

                // Вычисляем произведение
                int result = ds.Calculate(str);

                Console.WriteLine();
                Console.WriteLine($"Произведение четных чисел = {result}");

                // Детали расчета
                if (result != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Детали расчета:");
                    Console.WriteLine($"2 × 4 = 8");
                    Console.WriteLine($"8 × 8 = 64");
                    Console.WriteLine($"64 × 6 = 384");
                    Console.WriteLine($"384 × 2 = 768");
                    Console.WriteLine($"768 × 8 = {result}");
                }
                else
                {
                    Console.WriteLine("Четных чисел в матрице нет");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка! {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}