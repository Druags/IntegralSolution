using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegralSolution.Tests
{
    [TestClass]
    public class MainWindowXamlTest
    {
        [TestMethod]
        public void Wrong_Variables_Dont_Work_Upper_Index()

        {
            //arrange
            string a = "s";
            string b = "100";
            string n = "10000";

            //act

            //assert
        }

        [TestMethod]
        public void Wrong_Variables_Dont_Work_Lower_Index()
        {
            //arrange
            string a = "1";
            string b = "s";
            string n = "10000";
            //act

            //assert
        }

        [TestMethod]
        public void Wrong_Variables_Dont_Work_N()
        {
            //arrange
            string a = "10";
            string b = "100";
            string n = "s";
            //act

            //assert
        }
    }
}