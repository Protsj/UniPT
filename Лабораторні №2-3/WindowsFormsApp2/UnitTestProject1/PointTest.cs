using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void CreatePointTest() { var p = new Point(1, 1); }
        [TestMethod]
        public void GetPointXTest() 
        {
            var p = new Point(1, 1);
            var x = 1;
            Assert.AreEqual(x, p.X);
        }
        [TestMethod]
        public void GetPointYTest()
        {
            var p = new Point(1, 1);
            var y = 1;
            Assert.AreEqual(y, p.Y);
        }
        [TestMethod]
        public void MovePointTest()
        {
            var p = new Point(1, 1);
            p.Move(1, 1);
            var trueRes = new Point(2, 2);
            Assert.AreEqual(trueRes.X, p.X);
            Assert.AreEqual(trueRes.Y, p.Y);
        }
        [TestMethod]
        public void ScalePointTest()
        {
            var p = new Point(1, 1);
            p.Scale(2);
            var trueRes = new Point(2, 2);
            Assert.AreEqual(trueRes.X, p.X);
            Assert.AreEqual(trueRes.Y, p.Y);
        }
        [TestMethod]
        public void RotatePointTest()
        {
            var p = new Point(1, 1);
            p.Rotate(90);
            var trueRes = new Point(1, 1);
            Assert.AreEqual(trueRes.X, p.X);
            Assert.AreEqual(trueRes.Y, p.Y);
        }
    }
}
