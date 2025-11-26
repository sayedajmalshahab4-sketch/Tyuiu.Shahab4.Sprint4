using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Shahab4.Sprint4.Task7.V20.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string str = "357951248632587";
            int wait = 6144; // Четные числа: 2, 4, 8, 6, 2, 8 → 2 * 4 * 8 * 6 * 2 * 8 = 6144
            int res = ds.Calculate(str);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            string str = "357951248632587";
            int[,] wait = {
                { 3, 5, 7 },
                { 9, 5, 1 },
                { 2, 4, 8 },
                { 6, 3, 2 },
                { 5, 8, 7 }
            };

            int[,] res = ds.GetMatrix(str);

            // Проверяем размерности
            Assert.AreEqual(wait.GetLength(0), res.GetLength(0));
            Assert.AreEqual(wait.GetLength(1), res.GetLength(1));

            // Проверяем значения
            for (int i = 0; i < wait.GetLength(0); i++)
            {
                for (int j = 0; j < wait.GetLength(1); j++)
                {
                    Assert.AreEqual(wait[i, j], res[i, j]);
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyStringTest()
        {
            DataService ds = new DataService();
            ds.Calculate("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullStringTest()
        {
            DataService ds = new DataService();
            ds.Calculate(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidLengthTest()
        {
            DataService ds = new DataService();
            ds.Calculate("123"); // Слишком короткая строка
        }

        [TestMethod]
        public void NoEvenNumbersTest()
        {
            DataService ds = new DataService();

            string str = "135791357913579"; // Все нечетные
            int res = ds.Calculate(str);

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void MatrixToStringTest()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            string result = ds.MatrixToString(matrix);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Contains("1 2 3"));
            Assert.IsTrue(result.Contains("4 5 6"));
        }
    }
}