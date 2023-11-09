using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class SwimmingBird : Bird
    {
        private double lakeArea { get; set; }

        public SwimmingBird(string name, double lakeArea) : base(name) { this.lakeArea = lakeArea; }
        public override double getLandArea() { return lakeArea; }
        public override string getInfo() { return $"Назва: {Name} Площа озера: {lakeArea}м2"; }
    }
}
