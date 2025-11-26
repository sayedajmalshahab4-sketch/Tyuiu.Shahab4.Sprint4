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
        public void ValidGetEvenNumbers()
        {
            DataService ds = new DataService();

            string str = "357951248632587";
            string evenNumbers = ds.GetEvenNumbers(str);

            Assert.IsTrue(evenNumbers.Contains("2"));
            Assert.IsTrue(evenNumbers.Contains("4"));
            Assert.IsTrue(evenNumbers.Contains("6"));
            Assert.IsTrue(evenNumbers.Contains("8"));
        }

        [TestMethod]
        public void ManualCalculationCheck()
        {
            // Ручная проверка расчета
            int[] evenNumbers = { 2, 4, 8, 6, 2, 8 };
            int product = 1;

            foreach (int num in evenNumbers)
            {
                product *= num;
            }

            Assert.AreEqual(6144, product);
        }
    }
}