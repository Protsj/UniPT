using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.l5
{
    public class Point
    {
        double x, y, y_loop, y_rec;
        public Point(double x, double y, double y_loop, double y_rec)
        {
            this.x = x;
            this.y = y;
            this.y_loop = y_loop;
            this.y_rec = y_rec;
        }
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { x = value; } }
        public double Y_loop { get { return y_loop; } set { y_loop = value; } }
        public double Y_rec { get { return y_rec; } set { y_rec = value; } }
    }
}
