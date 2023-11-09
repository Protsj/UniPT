using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class SwimmingBirdTest
    {
        [TestMethod]
        public void getLandArea()
        {
            var fasb = new SwimmingBird("Пінгвін", 30);
            var testRes = 30;
            var trueRes = fasb.getLandArea();
            Assert.AreEqual(testRes, trueRes);
        }
    }
}
