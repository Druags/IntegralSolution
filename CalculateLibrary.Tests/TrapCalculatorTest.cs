using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateLibrary.Tests
{
    [TestClass]
    public class TrapCalculatorTest
    {
        [TestMethod]
        public void Trap_Intergrate_xx_Gives_Correct_Result()
        {
            //arrange
            double expected = 333_333.3333;
            double a = 0;
            double b = 100;
            long n = 100000;
            TrapCalculator trapCalculator = new TrapCalculator();
            Func<double, double> f = x => x * x;

            //act
            double actual = trapCalculator.Calculate(a, b, n, f);

            //assert

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Trap_Intergrate_xx_Gives_0()
        {
            //arrange
            double expected = 0;
            double a = 0;
            double b = a;

            long n = 100000;
            TrapCalculator trapCalculator = new TrapCalculator();
            Func<double, double> f = x => x * x;

            //act
            double actual = trapCalculator.Calculate(a, b, n, f);

            //assert

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        public void Trap_Intergrate_xx_negative_n()
        {
            //arrange
            double expected = 0;
            double a = 0;
            double b = 100;

            long n = -10;
            TrapCalculator trapCalculator = new TrapCalculator();
            Func<double, double> f = x => x * x;

            //act
            double actual = trapCalculator.Calculate(a, b, n, f);

            //assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        /*[TestMethod]
        public void Trap_Integrate_get_wrong_variables()
        {
            double expected = 0;
            // double a = a;
        }*/

        [TestMethod]
        public void Trap_Integrate_with_switched_variables()
        {
            //arrange
            double expected = -333_333.3333;
            double a = 100;
            double b = 0;
            long n = 100000;
            TrapCalculator trapCalculator = new TrapCalculator();
            Func<double, double> f = x => x * x;

            //act
            double actual = trapCalculator.Calculate(a, b, n, f);

            //assert
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}