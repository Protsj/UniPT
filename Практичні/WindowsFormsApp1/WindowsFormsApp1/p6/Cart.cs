using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    delegate void MyEventHandler();
    internal class Cart : IInfo
    {
        List<Commodity> commodities = new List<Commodity>();
        public List<Commodity> Commodities { get { return commodities; } }
        public void add(Commodity c) { commodities.Add(c); }
        public string info() { return $"Товарів в корзині: {commodities.Count}"; }
        
        public event MyEventHandler buy;
        public void buyCom() { if (buy != null) { buy(); } }
    }
}
