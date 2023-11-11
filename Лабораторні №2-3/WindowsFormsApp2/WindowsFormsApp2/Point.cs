using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Point
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }
        public virtual void Move(int num) {}
        public virtual void Scale(int scale) {}
        public virtual void Rotate(int angle) {}
    }
}
