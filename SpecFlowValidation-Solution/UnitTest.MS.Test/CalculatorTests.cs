using System;
using Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.MS.Test
{
    [TestClass]
    public class CalculatorTests
    {
        [TestCategory("Smoke")]
        [TestMethod]
        public void AddTest()
        {
           Example.Calculator calc = new Calculator();

            int expectedResult = 40;

            calc.FirstNumber = 10;
            calc.SecondNumber = 30;
            int result = calc.Add();
            Assert.AreEqual(expectedResult,result);
        }
    }
}
