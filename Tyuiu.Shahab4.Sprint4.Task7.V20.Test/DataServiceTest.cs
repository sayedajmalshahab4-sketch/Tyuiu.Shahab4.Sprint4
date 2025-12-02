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
            int res = ds.Calculate(str);
            int wait = 6144; // 2 * 4 * 8 * 6 * 2 * 8 = 6144

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidStringLength()
        {
            DataService ds = new DataService();

            string str = "12345";
            ds.Calculate(str);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StringContainsNonDigits()
        {
            DataService ds = new DataService();

            string str = "35795A248632587";
            ds.Calculate(str);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyString()
        {
            DataService ds = new DataService();

            string str = "";
            ds.Calculate(str);
        }

        [TestMethod]
        public void CalculateWithDifferentString()
        {
            DataService ds = new DataService();

            // Тест с другой строкой из 15 цифр
            string str = "123456789012345";
            int res = ds.Calculate(str);

            // Четные числа: 2,4,6,8,0,2,4
            // 2*4*6*8*0*2*4 = 0
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void CalculateWithAllEvenNumbers()
        {
            DataService ds = new DataService();

            string str = "246802468024680";
            int res = ds.Calculate(str);

            // Все числа четные, произведение всех чисел
            // Это большое число, но для теста проверим что не 0
            Assert.AreNotEqual(0, res);
        }
    }
}