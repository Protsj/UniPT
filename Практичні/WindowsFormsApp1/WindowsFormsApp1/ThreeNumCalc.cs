using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ThreeNumCalc
    {
        int n1, n2, n3 = 0;

        public ThreeNumCalc()
        {
            Random random = new Random();
            n1 = random.Next(0, 20);
            n2 = random.Next(0, 20);
            n3 = random.Next(0, 20);
        }

        public ThreeNumCalc(int n1, int n2, int n3)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
        }

        public int CubeOrSum()
        {
            if (n1 % 2 == 0 || n3 % 2 == 0 || n3 % 2 == 0)
                return (int)Math.Pow(n1 + n2 + n3, 3);
            return (int)(Math.Pow(n1, 3) + Math.Pow(n2, 3) + Math.Pow(n3, 3));
        }
    }
}
