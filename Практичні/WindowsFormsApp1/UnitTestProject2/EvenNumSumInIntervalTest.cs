using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1.p3;

namespace UnitTestProject2
{
    [TestClass]
    public class EvenNumSumInIntervalTest
    {
        [TestMethod]
        public void GetSumOfEvenNumsTest()
        {
            var calc = new EvenNumSumInInterval(0, 10);
            var TestResult = 30;
            var TrueResult = calc.GetSumOfEvenNums();
            Assert.AreEqual(TestResult, TrueResult);
        }
    }
}
