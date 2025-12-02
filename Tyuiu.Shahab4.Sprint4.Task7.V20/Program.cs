using System;
using Tyuiu.Shahab4.Sprint4.Task7.V20.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task7.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шахаб | АСиуб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Шагаб | АСиуб-25-1                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '357951248632587'. Преобразуйте      *");
            Console.WriteLine("* ее в матрицу 5 на 3 и подсчитайте произведение четных чисел.            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "357951248632587";
            Console.WriteLine($"Исходная строка = {str}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();

                // Вычисляем результат
                int result = ds.Calculate(str);

                // Показываем матрицу для наглядности
                int rows = 5;
                int columns = 3;
                int[,] matrix = ds.StringToMatrix(str, rows, columns);

                Console.WriteLine("\nПолученная матрица 5x3:");
                Console.WriteLine("------------------------");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{matrix[i, j]} \t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"\nПроизведение четных чисел = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИНФОРМАЦИЯ:                                                             *");
            Console.WriteLine("* Результат проверен на тестовых данных.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}