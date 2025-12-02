using System;
using Tyuiu.Shahab4.Sprint4.Task7.V20.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task7.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заголовок окна консоли
            Console.Title = "Спринт #4 | Выполнил: Шахаб | АСиуб-25-1";

            // Шапка задания
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Шахаб |                                             *");
            Console.WriteLine("***************************************************************************");

            // Условие задачи
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '357951248632587'. Преобразуйте      *");
            Console.WriteLine("* ее в матрицу 5 на 3 и подсчитайте произведение четных чисел.            *");
            Console.WriteLine("***************************************************************************");

            // Исходные данные
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "357951248632587";
            Console.WriteLine($"Исходная строка: {str}");
            Console.WriteLine($"Длина строки: {str.Length}");

            // Результат
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                // Создаем объект сервиса
                DataService ds = new DataService();

                // Преобразуем строку в матрицу и отображаем
                int rows = 5;
                int cols = 3;
                int[,] matrix = new int[rows, cols];

                Console.WriteLine("\nМатрица 5x3:");
                Console.WriteLine("-------------");

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        int index = i * cols + j;
                        matrix[i, j] = int.Parse(str[index].ToString());
                        Console.Write($"{matrix[i, j]}\t");
                    }
                    Console.WriteLine();
                }

                // Вычисляем результат
                int result = ds.Calculate(str);

                Console.WriteLine("\n-------------");
                Console.WriteLine($"Произведение четных чисел: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            // Информация о проверке
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИНФОРМАЦИЯ:                                                             *");
            Console.WriteLine("* Результат проверен на тестовых данных.                                  *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}