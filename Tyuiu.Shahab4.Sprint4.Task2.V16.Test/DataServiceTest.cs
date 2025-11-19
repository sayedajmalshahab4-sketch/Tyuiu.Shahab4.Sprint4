using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Shahab4.Sprint4.Task2.V16.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4 };
            int wait = 11907;
            int result = ds.Calculate(array);
            Assert.AreEqual(wait, result);
        }
    }
}