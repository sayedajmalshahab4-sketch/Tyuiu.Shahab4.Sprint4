using System;
using Tyuiu.Shahab4.Sprint4.Task0.V23.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task0.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Шахаб А. | АСОиУБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Шахаб А. | АСОиУБ-25-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать сумму         *");
            Console.WriteLine("* нечетных элементов массива. {9 ,3 ,7 ,1 ,5 ,5 ,3 ,2 ,1 ,7}             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetSumOddArrEl(array);
            Console.WriteLine($"Сумма нечетных элементов массива = {result}");

            Console.ReadKey();
        }
    }
}