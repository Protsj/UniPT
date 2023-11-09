using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.l3
{
    public class _3DVector : Vector
    {
        public double Size { get; set; }
        public _3DVector(double size)
        {
            type = "Тривимірний вектор";
            Size = size;
        }

        public override string ShowInfo() { return $"Тип: {type}; Розмірність: {Size}"; }
        public override double Length() { return Size; }
    }
}
