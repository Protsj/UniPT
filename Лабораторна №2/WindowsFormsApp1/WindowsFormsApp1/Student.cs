using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Student
    {
        private string name;
        private float s = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float S
        {
            get { return s; }
            set { s = value; }
        }

        public Student(string name, float s)
        {
            this.name = name;
            this.s = s;
        }

        public virtual float scholarship() { return 3000 + 1000 * (s - 5); }
    }
}
