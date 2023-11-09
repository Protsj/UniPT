using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1.l3;

namespace UnitTestProject1
{
    [TestClass]
    public class _3DVectorTest
    {
        [TestMethod]
        public void LengthTest()
        {
            var _3dv = new _3DVector(6.854);
            var testRes = 6.854;
            var trueRes = _3dv.Length();
            Assert.AreEqual(testRes, trueRes);
        }
    }
}
