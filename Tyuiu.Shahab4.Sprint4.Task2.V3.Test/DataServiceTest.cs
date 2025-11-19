using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Shahab4.Sprint4.Task2.V3.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 4, 3, 6, 2, 7, 4, 5, 2, 4, 6, 7, 4 };
            int wait = 32;
            int result = ds.Calculate(array);
            Assert.AreEqual(wait, result);
        }
    }
}