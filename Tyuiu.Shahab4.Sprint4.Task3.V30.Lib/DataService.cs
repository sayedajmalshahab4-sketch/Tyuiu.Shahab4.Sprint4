using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.Shahab4.Sprint4.Task3.V30.Lib
{
    public class DataService : ISprint4Task3V30
    {
        public DataService()
        {
        }

        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Поиск максимального элемента в третьей строке (индекс 2)
            int maxElement = matrix[2, 0];

            for (int j = 0; j < columns; j++)
            {
                if (matrix[2, j] > maxElement)
                {
                    maxElement = matrix[2, j];
                }
            }

            return maxElement;
        }
    }
}