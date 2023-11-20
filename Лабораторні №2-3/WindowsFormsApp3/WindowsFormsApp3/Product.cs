using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    internal class Product : Commodity
    {
        string expiryDate;
        public string ExpiryDate { get { return expiryDate; } }
        public Product(string name, double price, string expiryDate) : base(name, price) { this.expiryDate = expiryDate; }
        public override string info() { return $"Назва: {Name}, Ціна: {Price}, Термін придатності до: {expiryDate}."; }
    }

}
