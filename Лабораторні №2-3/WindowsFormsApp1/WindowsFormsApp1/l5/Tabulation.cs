using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace WindowsFormsApp1.l5
{
    public class Tabulation
    {
        public List<Point> points = new List<Point>();
        public void add(Point point) { points.Add(point); }
        public void getList(double xn, double xk, double h)
        {
            try
            {
                var x = xn;
                double y = 0, y_loop = 0, y_rec = 0;
                while (x < xk)
                {
                    var msx = new ModSinX(x);
                    y = Math.Abs(Math.Sin(x));
                    y_loop = msx.ModSinXLoop();
                    y_rec = msx.ModSinXRec(1, 0, 0);
                    var point = new Point(x, y, y_loop, y_rec);
                    add(point);
                    x = x + h;
                }
            }
            catch (Exception ex) { }
        }
    }
}
