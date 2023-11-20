using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class Toy : Commodity
    {
        int ageRange;
        public Toy(string name, double price, int ageRange) : base(name, price) { this.ageRange = ageRange; }
        public override string info() { return $"Назва: {Name}, Ціна: {Price}, Віком від: {ageRange} років."; }
    }
}
