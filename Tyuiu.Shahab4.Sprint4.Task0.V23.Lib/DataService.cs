using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.Shahab4.Sprint4.Task0.V23.Lib
{
    public class DataService : ISprint4Task0V23
    {
        public DataService()
        {
        }

        public int GetMultOddArrEl(int[] array)
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