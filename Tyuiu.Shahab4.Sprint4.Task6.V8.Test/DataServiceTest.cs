using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ2.Sprint4.Task6.V8.Lib;

namespace Tyuiu.ShahabAJ2.Sprint4.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            string[] wait = { "Пельмени", "Омлет", "Салат", "Роллы" };
            string[] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetCount()
        {
            DataService ds = new DataService();

            string[] array = { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            int wait = 4;
            int res = ds.GetCount(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void EmptyArrayTest()
        {
            DataService ds = new DataService();

            string[] array = { };
            string[] res = ds.Calculate(array);

            Assert.AreEqual(0, res.Length);
        }

        [TestMethod]
        public void NullArrayTest()
        {
            DataService ds = new DataService();

            string[] array = null;
            int res = ds.GetCount(array);

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void NoMatchesTest()
        {
            DataService ds = new DataService();

            string[] array = { "Суп", "Чай", "Кофе", "Сок" };
            string[] res = ds.Calculate(array);

            Assert.AreEqual(0, res.Length);
        }
    }
}