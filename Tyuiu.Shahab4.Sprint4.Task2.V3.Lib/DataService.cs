using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.Shahab4.Sprint4.Task2.V3.Lib
{
    public class DataService : ISprint4Task2V3
    {
        public DataService()
        {
        }

        public int Calculate(int[] array)
        {
            int sum = 0;

            // Суммирование четных элементов массива
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }
    }
}