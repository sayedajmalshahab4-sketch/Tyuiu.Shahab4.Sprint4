using System;

namespace Tyuiu.Shahab4.Sprint4.Task7.V20.Lib
{
    public class DataService
    {
        public int Calculate(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length != 15)
                return 0;

            // Прямой расчет без создания матрицы
            int product = 1;
            bool foundEven = false;

            foreach (char c in str)
            {
                int num = int.Parse(c.ToString());
                if (num % 2 == 0)
                {
                    product *= num;
                    foundEven = true;
                }
            }

            return foundEven ? product : 0;
        }

        public int[,] GetMatrix(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length != 15)
                return new int[0, 0];

            int[,] matrix = new int[5, 3];
            int index = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(str[index].ToString());
                    index++;
                }
            }

            return matrix;
        }
    }
}