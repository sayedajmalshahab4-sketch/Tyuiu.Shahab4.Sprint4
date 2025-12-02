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
            // Проверка входной строки
            if (string.IsNullOrEmpty(str))
                throw new ArgumentException("Строка не может быть пустой или null");

            if (str.Length != 15)
                throw new ArgumentException("Длина строки должна быть 15 символов для матрицы 5x3");

            // Преобразуем строку в матрицу 5x3
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

            // Подсчитываем произведение четных чисел
            int product = 1;
            bool hasEvenNumbers = false;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        product *= matrix[i, j];
                        hasEvenNumbers = true;
                    }
                }
            }

            // Если четных чисел нет, возвращаем 0
            return hasEvenNumbers ? product : 0;
        }

        public int Calculate(int n, int m, string value)
        {
            throw new NotImplementedException();
        }

        public int[,] GetMatrix(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length != 15)
                throw new ArgumentException("Некорректная строка");

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

        public string MatrixToString(int[,] matrix)
        {
            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += matrix[i, j] + " ";
                }
                result += "\n";
            }
            return result;
        }

        public long ProductOfEvenNumbers(int[,] matrix)
        {
            throw new NotImplementedException();
        }

        public int[,] StringToMatrix(string str, int rows, int columns)
        {
            throw new NotImplementedException();
        }
    }
}