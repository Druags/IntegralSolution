using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateLibrary.Tests
{
    [TestClass]
    public class RectangleCalculatorTest
    {
        [TestMethod]
        public void Intergrate_xx_Gives_Correct_Result()
        {
            //arrange
            double expected = 333_333.3333;
            double a = 0;
            double b = 100;
            long n = 100000;
            RectangleCalculator rectangleCalculator = new RectangleCalculator();
            Func<double, double> f = x => x * x;

            //act
            double actual = rectangleCalculator.Calculate(a, b, n, f);

            //assert

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Intergrate_xx_Gives_0()
        {
            //arrange
            double expected = 0;
            double a = 0;
            double b = a;

            long n = 100000;
            RectangleCalculator rectangleCalculator = new RectangleCalculator();
            Func<double, double> f = x => x * x;

            //act
            double actual = rectangleCalculator.Calculate(a, b, n, f);

            //assert

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Intergrate_xx_negative_n()
        {
            //arrange
            double expected = 0;
            double a = 0;
            double b = 100;

            long n = -10;
            RectangleCalculator rectangleCalculator = new RectangleCalculator();
            Func<double, double> f = x => x * x;

            //act
            double actual = rectangleCalculator.Calculate(a, b, n, f);

            //assert
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}