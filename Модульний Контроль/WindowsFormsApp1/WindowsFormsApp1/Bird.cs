using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Bird
    {
        string name = "";

        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }
        public Bird(string name)
        {
            this.Name = name;
        }
        public abstract double getLandArea();
        public abstract string getInfo();
    }
}
