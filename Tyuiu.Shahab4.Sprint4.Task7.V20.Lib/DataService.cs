using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.Shahab4.Sprint4.Task7.V20.Lib
{
    public class DataService : ISprint4Task7V20
    {
        public DataService()
        {
        }

        public int Calculate(string str)
        {
            Console.WriteLine($"Input string: {str}"); // Для отладки

            int[,] matrix = GetMatrix(str);
            int product = 1;
            bool hasEven = false;

            Console.WriteLine("Matrix values:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                    if (matrix[i, j] % 2 == 0)
                    {
                        product *= matrix[i, j];
                        hasEven = true;
                        Console.Write($"(even) ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Final product: {product}");
            return hasEven ? product : 0;
        }

        public int Calculate(int n, int m, string value)
        {
            throw new NotImplementedException();
        }

        public int[,] GetMatrix(string str)
        {
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