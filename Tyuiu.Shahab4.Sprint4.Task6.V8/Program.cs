using System;
using Tyuiu.ShahabAJ2.Sprint4.Task6.V8.Lib;

namespace Tyuiu.ShahabAJ2.Sprint4.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шахаб А. Дж. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Шахаб А. Дж. | СМАРТб-25-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array, выведите элементы   *");
            Console.WriteLine("* массива, длина которых больше 4 символов.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i}] = {array[i]} (длина: {array[i].Length})");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string[] result = ds.Calculate(array);
            int count = ds.GetCount(array);

            Console.WriteLine("Элементы массива, длина которых больше 4 символов:");
            if (result.Length > 0)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {result[i]}");
                }
                Console.WriteLine($"\nОбщее количество элементов: {count}");
            }
            else
            {
                Console.WriteLine("Нет элементов, удовлетворяющих условию");
            }

            Console.ReadKey();
        }
    }
}