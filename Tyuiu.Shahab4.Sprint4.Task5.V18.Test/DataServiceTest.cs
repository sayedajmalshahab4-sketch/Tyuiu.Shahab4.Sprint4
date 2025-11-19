using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Shahab4.Sprint4.Task5.V18.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = {
                { -5, 3, -2, 7, 0 },
                { 4, -1, 6, -3, 2 },
                { -4, 5, 1, -6, 7 },
                { 3, -2, 0, 4, -1 },
                { 6, -3, 5, 2, -4 }
            };
            int[,] wait = {
                { 0, 3, 0, 7, 0 },
                { 4, 0, 6, 0, 2 },
                { 0, 5, 1, 0, 7 },
                { 3, 0, 0, 4, 0 },
                { 6, 0, 5, 2, 0 }
            };
            int[,] result = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, result);
        }
    }
}