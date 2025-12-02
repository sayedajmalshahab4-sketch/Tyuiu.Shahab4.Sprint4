using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Shahab4.Sprint4.Task7.V20.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToMatrix()
        {
            DataService ds = new DataService();

            string str = "357951248632587";
            int rows = 5;
            int columns = 3;

            int[,] matrix = ds.StringToMatrix(str, rows, columns);

            int wait_rows = 5;
            int wait_columns = 3;

            Assert.AreEqual(wait_rows, matrix.GetLength(0));
            Assert.AreEqual(wait_columns, matrix.GetLength(1));
        }

        [TestMethod]
        public void ValidCalculateProductOfEvenNumbers()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 3]
            {
                { 3, 5, 7 },
                { 9, 5, 1 },
                { 2, 4, 8 },
                { 6, 3, 2 },
                { 5, 8, 7 }
            };

            long res = ds.ProductOfEvenNumbers(matrix);
            long wait = 6144; // 2 * 4 * 8 * 6 * 2 * 8 = 6144

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidIntegrationTest()
        {
            DataService ds = new DataService();

            string str = "357951248632587";
            int rows = 5;
            int columns = 3;

            int[,] matrix = ds.StringToMatrix(str, rows, columns);
            long product = ds.ProductOfEvenNumbers(matrix);

            long wait = 6144;

            Assert.AreEqual(wait, product);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidStringLength()
        {
            DataService ds = new DataService();

            string str = "12345";
            int rows = 5;
            int columns = 3;

            ds.StringToMatrix(str, rows, columns);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StringContainsNonDigits()
        {
            DataService ds = new DataService();

            string str = "35795A248632587";
            int rows = 5;
            int columns = 3;

            ds.StringToMatrix(str, rows, columns);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyString()
        {
            DataService ds = new DataService();

            string str = "";
            int rows = 5;
            int columns = 3;

            ds.StringToMatrix(str, rows, columns);
        }

        [TestMethod]
        public void MatrixWithoutEvenNumbers()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[2, 2]
            {
                { 1, 3 },
                { 5, 7 }
            };

            long res = ds.ProductOfEvenNumbers(matrix);
            long wait = 0;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullMatrix()
        {
            DataService ds = new DataService();

            ds.ProductOfEvenNumbers(null);
        }

        [TestMethod]
        public void CheckMatrixValuesFromString()
        {
            DataService ds = new DataService();

            string str = "357951248632587";
            int rows = 5;
            int columns = 3;

            int[,] matrix = ds.StringToMatrix(str, rows, columns);

            // Проверка значений первой строки
            Assert.AreEqual(3, matrix[0, 0]);
            Assert.AreEqual(5, matrix[0, 1]);
            Assert.AreEqual(7, matrix[0, 2]);

            // Проверка значений третьей строки (четные числа)
            Assert.AreEqual(2, matrix[2, 0]);
            Assert.AreEqual(4, matrix[2, 1]);
            Assert.AreEqual(8, matrix[2, 2]);
        }

        [TestMethod]
        public void ProductWithSingleEvenNumber()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[1, 3]
            {
                { 1, 2, 3 }
            };

            long res = ds.ProductOfEvenNumbers(matrix);
            long wait = 2;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ProductWithZero()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[1, 3]
            {
                { 2, 0, 4 }
            };

            long res = ds.ProductOfEvenNumbers(matrix);
            long wait = 0; // 2 * 0 * 4 = 0

            Assert.AreEqual(wait, res);
        }
    }
}