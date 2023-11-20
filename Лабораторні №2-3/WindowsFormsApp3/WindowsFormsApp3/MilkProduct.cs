using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class MilkProduct : Product
    {
        public MilkProduct(string name, double price, string expiryDate) : base(name, price, expiryDate) {}
        public override string info() { return $"Назва: {Name}, Ціна: {Price}, Термін придатності до: {ExpiryDate}."; }
    }
}
