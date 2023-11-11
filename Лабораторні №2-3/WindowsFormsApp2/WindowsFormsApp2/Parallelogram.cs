using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Parallelogram : Shape
    {
        public Parallelogram(Point[] points) : base(4) { Points = points; }
    }
}
