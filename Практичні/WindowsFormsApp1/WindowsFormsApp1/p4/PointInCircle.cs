using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.p4
{
    internal class PointInCircle
    {
        public int[] x;
        public int[] y;
        public PointInCircle(int size = 10) 
        {
            x = new int[size];
            y = new int[size];
        }

        public bool pointsAreInCircle()
        {
            for(int i = 0; i < x.Length; i++)
            {
                double distance = Math.Sqrt(Math.Pow(x[i], 2) + Math.Pow(y[i], 2));
                if (distance > 3)
                    return false;
            }
            return true;
        }
    }
}
