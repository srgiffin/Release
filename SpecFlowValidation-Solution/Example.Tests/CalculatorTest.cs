// <copyright file="CalculatorTest.cs">Copyright ©  2017</copyright>
using System;
using Example;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Example.Tests
{
    /// <summary>This class contains parameterized unit tests for Calculator</summary>
    [PexClass(typeof(Calculator))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CalculatorTest
    {
        /// <summary>Test stub for Add()</summary>
        [PexMethod]
        public int AddTest([PexAssumeUnderTest]Calculator target)
        {
            target.FirstNumber = 10;
            target.SecondNumber = 30;
            int result = target.Add();

            int expected = 40;
            Assert.AreEqual(expected,result);
            return result;
           
            // TODO: add assertions to method CalculatorTest.AddTest(Calculator)
        }
    }
}
