using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1.l3;

namespace UnitTestProject1
{
    [TestClass]
    public class _2DVectorTest
    {
        [TestMethod]
        public void LengthTest()
        {
            var _2dv = new _2DVector(2.2, 4.1);
            var testRes = 4.653;
            var trueRes = Math.Round(_2dv.Length(), 4);
            Assert.AreEqual(testRes, trueRes);
        }
    }
}
