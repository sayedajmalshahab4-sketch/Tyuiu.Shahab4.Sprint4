using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Shahab4.Sprint4.Task7.V20.Lib
{
    public class DataService : ISprint4Task7V20
    {
        /// <summary>
        /// Основной метод для расчета произведения четных чисел в матрице 5x3
        /// </summary>
        /// <param name="str">Строка из 15 цифр</param>
        /// <returns>Произведение четных чисел</returns>
        public int Calculate(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Строка не может быть пустой");
            }

            if (str.Length != 15)
            {
                throw new ArgumentException($"Строка должна содержать 15 символов. Передано: {str.Length}");
            }

            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    throw new ArgumentException($"Строка должна содержать только цифры. Обнаружен символ: '{c}'");
                }
            }

            // Создаем матрицу 5x3
            int rows = 5;
            int columns = 3;
            int[,] matrix = new int[rows, columns];

            // Заполняем матрицу
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int index = i * columns + j;
                    matrix[i, j] = int.Parse(str[index].ToString());
                }
            }

            // Вычисляем произведение четных чисел
            int product = 1;
            bool hasEven = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        product *= matrix[i, j];
                        hasEven = true;
                    }
                }
            }

            return hasEven ? product : 0;
        }

        // Старые методы можно оставить для обратной совместимости
        public int[,] StringToMatrix(string str, int rows, int columns)
        {
            if (str.Length != rows * columns)
            {
                throw new ArgumentException($"Неверная длина строки. Ожидалось {rows * columns}, получено {str.Length}");
            }

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(str[i * columns + j].ToString());
                }
            }

            return matrix;
        }

        public int ProductOfEvenNumbers(int[,] matrix)
        {
            int product = 1;
            bool hasEven = false;

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        product *= matrix[i, j];
                        hasEven = true;
                    }
                }
            }

            return hasEven ? product : 0;
        }

        public int Calculate(int n, int m, string value)
        {
            throw new NotImplementedException();
        }
    }
}