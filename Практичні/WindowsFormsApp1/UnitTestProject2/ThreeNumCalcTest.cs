using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1.p3;

namespace UnitTestProject2
{
    [TestClass]
    public class ThreeNumCalcTest
    {
        [TestMethod]
        public void HasEvenNum()
        {
            var calc = new ThreeNumCalc(1, 2, 3);
            int TestResult = 216;
            int TrueResult = calc.CubeOrSum();
            Assert.AreEqual(TestResult, TrueResult);
        }

        [TestMethod]
        public void NoEvenNum()
        {
            var calc = new ThreeNumCalc(1, 3, 5);
            int TestResult = 153;
            int TrueResult = calc.CubeOrSum();
            Assert.AreEqual(TestResult, TrueResult);
        }
    }
}
