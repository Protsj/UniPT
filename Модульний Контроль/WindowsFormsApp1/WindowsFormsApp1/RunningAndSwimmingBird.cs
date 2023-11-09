using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RunningAndSwimmingBird : Bird
    {
        private double fenceAndLakeArea { get; set; } 
        private double landArea { get; set; }

        public RunningAndSwimmingBird(string name, double fenceAndLakeArea, double landArea) : base(name) 
        {
            this.fenceAndLakeArea = fenceAndLakeArea;
            this.landArea = landArea;
        }
        public override double getLandArea() { return fenceAndLakeArea + landArea; }
        public override string getInfo() { return $"Назва: {Name} Площа огорожі та озера: {fenceAndLakeArea}м2 Площа суші: {landArea}м2"; }
    }
}
