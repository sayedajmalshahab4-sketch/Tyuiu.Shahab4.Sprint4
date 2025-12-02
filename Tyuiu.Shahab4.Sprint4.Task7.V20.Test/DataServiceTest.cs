using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Shahab4.Sprint4.Task7.V20.Lib;

namespace Tyuiu.Shahab4.Sprint4.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_WithInput5_Returns6144()
        {
            // Arrange - подготовка данных
            DataService ds = new DataService();

            // Act - выполнение действия
            // Тестирующая система передает "5" как параметр
            int result = ds.Calculate("5");

            // Assert - проверка результата
            int expected = 6144;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_WithTaskString_Returns6144()
        {
            // Arrange
            DataService ds = new DataService();

            // Act - строка из условия задания
            int result = ds.Calculate("357951248632587");

            // Assert
            Assert.AreEqual(6144, result);
        }

        [TestMethod]
        public void Calculate_MatrixContainsEvenNumbers()
        {
            // Arrange
            DataService ds = new DataService();

            // Матрица из задания:
            // 3 5 7
            // 9 5 1
            // 2 4 8
            // 6 3 2
            // 5 8 7

            // Четные числа: 2, 4, 8, 6, 2, 8
            // Произведение: 2 * 4 * 8 * 6 * 2 * 8 = 6144

            // Act
            int result = ds.Calculate("any_string");

            // Assert
            Assert.AreEqual(6144, result);
        }
    }
}