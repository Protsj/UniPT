using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class ThreeNumCalcTest
    {
        [TestMethod]
        public void HasEvenNum()
        {
            var calc = new ThreeNumCalc(1, 2, 3);
            int TrueResult = 216;
            int testresult = calc.CubeOrSum();
        }
    }
}
