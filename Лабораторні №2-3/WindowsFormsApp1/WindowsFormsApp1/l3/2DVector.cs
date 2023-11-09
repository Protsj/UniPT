using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.l3
{
    public class _2DVector : Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public _2DVector(double x, double y)
        {
            type = "Двовимірний вектор";
            X = x;
            Y = y;
        }

        public override string ShowInfo() { return $"Тип: {type}; Координати: ({X}, {Y})"; }
        public override double Length() { return Math.Round(Math.Sqrt(X * X + Y * Y), 2); }
    }
}
