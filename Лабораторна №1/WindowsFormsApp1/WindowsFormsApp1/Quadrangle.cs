using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Quadrangle
    {
        int s1, s2, s3, s4;

        public Quadrangle(int s1, int s2, int s3, int s4)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            this.s4 = s4;
        }

        private void RandGenerate(int a, int b)
        {
            Random r = new Random();
            this.s1 = r.Next(a, b);
            this.s2 = r.Next(a, b);
            this.s3 = r.Next(a, b);
            this.s4 = r.Next(a, b);
        }

        public Quadrangle(int a, int b)
        {
            RandGenerate(a, b);
        }

        public Quadrangle()
        {
            RandGenerate(0, 100);
        }

        public int S1 { get { return s1; } }

        public int S2 { get { return s2; } }

        public int S3 { get { return s3; } }

        public int S4 { get { return s4; } }

        public bool IsParallelogram() { return (s1 == s3 && s2 == s4); }
    }
}
