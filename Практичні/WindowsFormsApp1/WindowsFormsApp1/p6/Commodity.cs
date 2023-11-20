using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal class Commodity : IInfo, IAddToCart
    {
        string name;
        double price = 0.0;
        public string Name { get { return name; } }
        public double Price { get { return price; } }
        public Commodity(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public virtual string info() { return $"Назва: {name}, Ціна: {price}."; }
        public string buy() { return $"Ви купили {name} за {price}$."; }
        public string addToCart() { return $"{name} додано до корзини."; }
        public void ComAddEvent()
        {
            MessageBox.Show(addToCart());
        }
        public void ComBuyEvent()
        {
            MessageBox.Show(buy());
        }
    }
}
