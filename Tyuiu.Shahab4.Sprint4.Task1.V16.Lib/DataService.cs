using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.Shahab4.Sprint4.Task1.V16.Lib
{
    public class DataService : ISprint4Task1V16
    {
        public DataService()
        {
        }

        public int Calculate(int[] array)
        {
            int product = 1;

            // Произведение нечетных элементов массива
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    product *= array[i];
                }
            }

            return product;
        }
    }
}