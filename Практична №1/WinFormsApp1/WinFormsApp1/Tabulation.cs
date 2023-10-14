using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Tabulation
    {
        public double[,] mat = new double[100, 2];
        public int n = 0;
        private double f1(double x) { return Math.Pow(Math.E, -2*x)+Math.Pow(2 * Math.Pow(x, 4) + Math.Pow(x, 2) - 1, 1.0 / 7.0); }
        private double f2(double x) { return (Math.Pow(x, 3) + 2 * Math.Pow(x, 2) - 4 * x) / (Math.Pow(x, 5) * Math.Tan(1.0 / (2 * Math.Pow(x, 3)))); }
        private double f3(double x) { return (Math.Pow(Math.Cos(Math.Pow(x + 2, 3)), 2)) / (2 * Math.Pow(Math.Pow(x, 3), 1.0 / 2.0) * Math.Sin(Math.Pow(x, 3))); }

        public void tabulate(double xn = 2.9, double xk = 17.48, double xh = 0.1, double a = 0.8)
        {
            double x = xn, y;
            int i = 0;
            while(x <= xk)
            {
                if (x < 0)
                    y = f1(x);
                else if ((x >= 0) && (x < a))
                    y = f2(x);
                else
                    y = f3(x);
                mat[i, 0] = x;
                mat[i, 1] = y;
                x = x + xh;
                i++;
            }
            n = i;
        }
    }
}
