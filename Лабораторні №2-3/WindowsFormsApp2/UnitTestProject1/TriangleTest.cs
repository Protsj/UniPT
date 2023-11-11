using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void moveTest()
        {
            Point[] points = { new Point(5, 5), new Point(15, 5), new Point(10, 10) };
            var t = new Triangle(points);
            Point[] testRes = { new Point(7, 7), new Point(17, 7), new Point(12, 12) };
            t.Move(2, 2);
            Point[] trueRes = t.Points;
            for (int i = 0; i < testRes.Length; i++)
            {
                Assert.AreEqual(testRes[i].X, trueRes[i].X);
                Assert.AreEqual(testRes[i].Y, trueRes[i].Y);
            }
        }

        [TestMethod]
        public void ScaleTest()
        {
            Point[] points = { new Point(5, 5), new Point(15, 5), new Point(10, 10) };
            var t = new Triangle(points);
            Point[] testRes = { new Point(10, 10), new Point(30, 10), new Point(20, 20) };
            t.Scale(2);
            Point[] trueRes = t.Points;
            for (int i = 0; i < testRes.Length; i++)
            {
                Assert.AreEqual(testRes[i].X, trueRes[i].X);
                Assert.AreEqual(testRes[i].Y, trueRes[i].Y);
            }
        }

        [TestMethod]
        public void RotateTest()
        {
            Point[] points = { new Point(5, 5), new Point(15, 5), new Point(10, 10) };
            var t = new Triangle(points);
            Point[] testRes = { new Point((float)11.667, (float)1.667), new Point((float)11.667, (float)11.667), new Point((float)6.667, (float)6.667) };
            t.Rotate(90);
            Point[] trueRes = t.Points;
            for (int i = 0; i < testRes.Length; i++)
            {
                Assert.AreEqual(Math.Round(testRes[i].X, 3), Math.Round(trueRes[i].X, 3));
                Assert.AreEqual(Math.Round(testRes[i].Y, 3), Math.Round(trueRes[i].Y, 3));
            }
        }
    }
}
