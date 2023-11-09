using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class RunningAndSwimmingBirdTest
    {
        [TestMethod]
        public void getLandArea()
        {
            var fasb = new RunningAndSwimmingBird("Ківі", 13.5, 53.1);
            var testRes = 66.6;
            var trueRes = fasb.getLandArea();
            Assert.AreEqual(testRes, trueRes);
        }
    }
}
