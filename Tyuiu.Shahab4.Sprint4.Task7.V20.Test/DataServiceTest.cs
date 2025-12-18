using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Shahab4.Sprint4.Task7.V20.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();

            string str = "357951248632587";
            int result = ds.Calculate(str);
            int wait = 6144;  // 2 * 4 * 8 * 6 * 2 * 8 = 6144

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void CalculateTestNoEven()
        {
            DataService ds = new DataService();

            string str = "135791357913579";
            int result = ds.Calculate(str);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculateTestOneEven()
        {
            DataService ds = new DataService();

           
            string str = "111111111111112";
            int result = ds.Calculate(str);

            Assert.AreEqual(2, result);
        }
    }
}