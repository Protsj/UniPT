using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class FlyingAndSwimmingBird : Bird
    {
        private double netAndLakeArea { get; set; } 
        private double landArea { get; set; }
        public FlyingAndSwimmingBird(string name, double netAndLakeArea, double landArea) : base(name)
        {
            this.netAndLakeArea = netAndLakeArea;
            this.landArea = landArea;
        }
        public override double getLandArea() { return netAndLakeArea + landArea; }
        public override string getInfo() { return $"Назва: {Name} Площа сітки та озера: {netAndLakeArea}м2 Площа суші: {landArea}м2"; }
    }
}
