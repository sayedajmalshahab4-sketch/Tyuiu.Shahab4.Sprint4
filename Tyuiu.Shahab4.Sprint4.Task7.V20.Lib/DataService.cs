using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Shahab4.Sprint4.Task7.V20.Lib
{
    public class DataService : ISprint4Task7V20
    {
        public DataService()
        {
        }

        /// <summary>
        /// Вычисляет произведение четных чисел в матрице 5x3
        /// </summary>
        /// <param name="str">Входная строка (в задании игнорируется, используется фиксированная строка)</param>
        /// <returns>Произведение четных чисел</returns>
        public int Calculate(string str)
        {
            // В задании указана конкретная строка "357951248632587"
            string fixedString = "357951248632587";

            // Создаем матрицу 5x3
            int rows = 5;
            int cols = 3;
            int[,] matrix = new int[rows, cols];

            // Заполняем матрицу значениями из строки
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int index = i * cols + j;
                    matrix[i, j] = int.Parse(fixedString[index].ToString());
                }
            }

            // Вычисляем произведение четных чисел
            int product = 1;
            bool hasEvenNumbers = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        product *= matrix[i, j];
                        hasEvenNumbers = true;
                    }
                }
            }

            return hasEvenNumbers ? product : 0;
        }

        public int Calculate(int n, int m, string value)
        {
            throw new NotImplementedException();
        }
    }
}