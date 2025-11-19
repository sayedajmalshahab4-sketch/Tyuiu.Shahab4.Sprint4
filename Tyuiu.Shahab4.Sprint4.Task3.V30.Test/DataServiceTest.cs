using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Shahab4.Sprint4.Task3.V30.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = {
                { 2, 4, 3, 5, 1 },
                { 6, 6, 1, 2, 6 },
                { 3, 3, 2, 1, 5 },
                { 6, 4, 1, 3, 3 },
                { 5, 1, 1, 6, 4 }
            };
            int wait = 5;
            int result = ds.Calculate(matrix);
            Assert.AreEqual(wait, result);
        }
    }
}