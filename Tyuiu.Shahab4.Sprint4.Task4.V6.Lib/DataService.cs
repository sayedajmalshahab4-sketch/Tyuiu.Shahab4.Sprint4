using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.Shahab4.Sprint4.Task4.V6.Lib
{
    public class DataService : ISprint4Task4V6
    {
        public DataService()
        {
        }

        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Замена нечетных элементов на 0
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}