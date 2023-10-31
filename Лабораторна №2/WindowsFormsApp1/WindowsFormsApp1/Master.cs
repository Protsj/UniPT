using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Master : Student
    {
        private string specialty;
        private float m = 0;

        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }
        public float M
        {
            get { return m; }
            set { m = value; }
        }
        public Master(string name, float s, string specialty, float m) : base(name, s)
        {
            this.Name = name;
            this.S = s;
            this.specialty = specialty;
            this.m = m;
        }

        public override float scholarship() { return base.scholarship() + m; }
    }
}
