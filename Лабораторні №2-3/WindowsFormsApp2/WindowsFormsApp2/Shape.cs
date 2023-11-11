using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public abstract class Shape
    {
        public Point[] Points { get; set; }

        public Shape(int n) { Points = new Point[n]; }

        public void Move(int x, int y) 
        {
            foreach (var p in Points)
            {
                p.X += x;
                p.Y += y;
            }
        }
        public void Scale(int scale) 
        {
            foreach (var point in Points)
            {
                point.X *= scale;
                point.Y *= scale;
            }
        }
        public void Rotate(int angle)
        {
            double radAngle = angle * Math.PI / 180;
            Point center = CalculateCenter();
            foreach (var point in Points)
            {
                float deltaX = point.X - center.X;
                float deltaY = point.Y - center.Y;
                point.X = center.X + (float)(deltaX * Math.Cos(radAngle) - deltaY * Math.Sin(radAngle));
                point.Y = center.Y + (float)(deltaX * Math.Sin(radAngle) + deltaY * Math.Cos(radAngle));
            }
        }
        private Point CalculateCenter()
        {
            float sumX = 0;
            float sumY = 0;

            foreach (var point in Points)
            {
                sumX += point.X;
                sumY += point.Y;
            }

            return new Point(sumX / Points.Length, sumY / Points.Length);
        }
    }
}
