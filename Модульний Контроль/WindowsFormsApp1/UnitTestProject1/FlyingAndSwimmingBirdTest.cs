using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class FlyingAndSwimmingBirdTest
    {
        [TestMethod]
        public void getLandArea()
        {
            var fasb = new FlyingAndSwimmingBird("Качка", 8, 35);
            var testRes = 43;
            var trueRes = fasb.getLandArea();
            Assert.AreEqual(testRes, trueRes);
        }
    }
}
