using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShahabAJ2.Sprint4.Task6.V8.Lib
{
    public class DataService : ISprint4Task6V8
    {
        public DataService()
        {
        }

        public string[] Calculate(string[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array), "Массив не может быть null");

            // Используем Array.FindAll для фильтрации элементов длиной больше 4 символов
            string[] result = Array.FindAll(array, element => element != null && element.Length > 4);

            return result;
        }

        public int GetCount(string[] array)
        {
            if (array == null)
                return 0;

            // Используем Array.FindAll и получаем длину результата
            return Array.FindAll(array, element => element != null && element.Length > 4).Length;
        }
    }
}