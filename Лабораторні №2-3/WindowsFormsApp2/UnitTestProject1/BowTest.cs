using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class BowTest
    {
        [TestMethod]
        public void CreateBowTest()
        {
            Point[] points = { new Point(5, 5), new Point(5, 15), new Point(10, 10), new Point(15, 5), new Point(15, 10) };
            var p = new Bow(points);
        }
        [TestMethod]
        public void GetBowPointsTest()
        {
            Point[] points = { new Point(5, 5), new Point(5, 15), new Point(10, 10), new Point(15, 5), new Point(15, 10) };
            var p = new Bow(points);
            Point[] trueRes = p.Points;
            for (int i = 0; i < points.Length; i++)
            {
                Assert.AreEqual(points[i].X, trueRes[i].X);
                Assert.AreEqual(points[i].Y, trueRes[i].Y);
            }
        }
        [TestMethod]
        public void moveTest()
        {
            Point[] points = { new Point(5, 5), new Point(5, 15), new Point(10, 10), new Point(15, 5), new Point(15, 10) };
            var b = new Bow(points); 
            Point[] testRes = { new Point(7, 7), new Point(7, 17), new Point(12, 12), new Point(17, 7), new Point(17, 12) };
            b.Move(2, 2);
            Point[] trueRes = b.Points;
            for (int i = 0; i < testRes.Length; i++)
            {
                Assert.AreEqual(testRes[i].X, trueRes[i].X);
                Assert.AreEqual(testRes[i].Y, trueRes[i].Y);
            }
        }

        [TestMethod]
        public void ScaleTest()
        {
            Point[] points = { new Point(5, 5), new Point(5, 15), new Point(10, 10), new Point(15, 5), new Point(15, 10) };
            var b = new Bow(points);
            Point[] testRes = { new Point(10, 10), new Point(10, 30), new Point(20, 20), new Point(30, 10), new Point(30, 20) };
            b.Scale(2);
            Point[] trueRes = b.Points;
            for (int i = 0; i < testRes.Length; i++)
            {
                Assert.AreEqual(testRes[i].X, trueRes[i].X);
                Assert.AreEqual(testRes[i].Y, trueRes[i].Y);
            }
        }

        [TestMethod]
        public void RotateTest()
        {
            Point[] points = { new Point(5, 5), new Point(5, 15), new Point(10, 10), new Point(15, 5), new Point(15, 10) };
            var b = new Bow(points);
            Point[] testRes = { new Point(14, 4), new Point(4, 4), new Point(9, 9), new Point(14, 14), new Point(9, 14) };
            b.Rotate(90);
            Point[] trueRes = b.Points;
            for (int i = 0; i < testRes.Length; i++)
            {
                Assert.AreEqual(testRes[i].X, trueRes[i].X);
                Assert.AreEqual(testRes[i].Y, trueRes[i].Y);
            }
        }
    }
}
