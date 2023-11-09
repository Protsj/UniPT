using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.p4
{
    internal class ShowArray
    {
        public string writeArray(int[] a)
        {
            string s = "";
            foreach(int i in a)
                s += i.ToString() + " ";
            return s;
        }
    }
}
