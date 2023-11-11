using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class ParallelogramTest
    {
        [TestMethod]
        public void moveTest()
        {
            Point[] points = { new Point(10, 10), new Point(5, 5), new Point(20, 10), new Point(15, 5) };
            var s = new Parallelogram(points);
            Point[] testRes = { new Point(12, 12), new Point(7, 7), new Point(22, 12), new Point(17, 7) };
            s.Move(2, 2);
            Point[] trueRes = s.Points;
            for (int i = 0; i < testRes.Length; i++)
            {
                Assert.AreEqual(testRes[i].X, trueRes[i].X);
                Assert.AreEqual(testRes[i].Y, trueRes[i].Y);
            }
        }

        [TestMethod]
        public void ScaleTest()
        {
            Point[] points = { new Point(10, 10), new Point(5, 5), new Point(20, 10), new Point(15, 5) };
            var s = new Parallelogram(points);
            Point[] testRes = { new Point(20, 20), new Point(10, 10), new Point(40, 20), new Point(30, 10) };
            s.Scale(2);
            Point[] trueRes = s.Points;
            for (int i = 0; i < testRes.Length; i++)
            {
                Assert.AreEqual(testRes[i].X, trueRes[i].X);
                Assert.AreEqual(testRes[i].Y, trueRes[i].Y);
            }
        }

        [TestMethod]
        public void RotateTest()
        {
            Point[] points = { new Point(10, 10), new Point(5, 5), new Point(20, 10), new Point(15, 5) };
            var s = new Parallelogram(points);
            Point[] testRes = { new Point(10, 5), new Point(15, 0), new Point(10, 15), new Point(15, 10) };
            s.Rotate(90);
            Point[] trueRes = s.Points;
            for (int i = 0; i < testRes.Length; i++)
            {
                Assert.AreEqual(testRes[i].X, trueRes[i].X);
                Assert.AreEqual(testRes[i].Y, trueRes[i].Y);
            }
        }
    }
}
