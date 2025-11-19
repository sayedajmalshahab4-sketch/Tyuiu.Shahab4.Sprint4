using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Shahab4.Sprint4.Task0.V23.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int wait = 2083725;
            int result = ds.GetMultOddArrEl(array);
            Assert.AreEqual(wait, result);
        }
    }
}