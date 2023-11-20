using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Cart cart = new Cart();

        Cart shop = new Cart();
        Product p1 = new Product("Coca-cola", 1.29, "20/11/2024");
        Product p2 = new Product("Хліб Український", 0.83, "13/10/2023");
        Product p3 = new Product("Пиріжок з вишнею", 1.05, "10/10/2023");
        Product p4 = new Product("Соняшникова олія", 2.61, "18/01/2024");
        MilkProduct mp1 = new MilkProduct("Масло вершкове", 3.88, "16/10/2023");
        MilkProduct mp2 = new MilkProduct("Молоко", 2.89, "19/10/2023");
        MilkProduct mp3 = new MilkProduct("Сир солодкий", 2.11, "14/10/2023");
        Toy t1 = new Toy("Набір Lego", 11.23, 9);
        Toy t2 = new Toy("Машинка HotWheels", 8.34, 6);
        Toy t3 = new Toy("Іграшковий пістолет", 5.69, 13);
        Toy t4 = new Toy("М'який ведмедик", 4.01, 1);
        Toy t5 = new Toy("Пазл(1000 частин)", 2.87, 4);
        public Form1()
        {
            InitializeComponent();
            shop.add(p1);
            shop.add(p2);
            shop.add(p3);
            shop.add(p4);
            shop.add(mp1);
            shop.add(mp2);
            shop.add(mp3);
            shop.add(t1);
            shop.add(t2);
            shop.add(t3);
            shop.add(t4);
            shop.add(t5);
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(p1.info());
            dataGridView1.Rows.Add(p2.info());
            dataGridView1.Rows.Add(p3.info());
            dataGridView1.Rows.Add(p4.info());
            dataGridView1.Rows.Add(mp1.info());
            dataGridView1.Rows.Add(mp2.info());
            dataGridView1.Rows.Add(mp3.info());
            dataGridView1.Rows.Add(t1.info());
            dataGridView1.Rows.Add(t2.info());
            dataGridView1.Rows.Add(t3.info());
            dataGridView1.Rows.Add(t4.info());
            dataGridView1.Rows.Add(t5.info());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var i = dataGridView1.CurrentRow.Index;
            cart.add(shop.Commodities[i]);
            dataGridView2.Rows.Add(shop.Commodities[i].info());
            shop.Commodities[i].ComAddEvent();
            label2.Text = $"Корзина (товарів: {cart.Commodities.Count})";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cart.Commodities.Count == 0)
                    throw new Exception("Товарів в корзині немає!");
                foreach (var item in cart.Commodities)
                    cart.buy += new MyEventHandler(item.ComBuyEvent);
                cart.buyCom();
                MessageBox.Show("Товари були куплені.");
                dataGridView2.Rows.Clear();
                cart.Commodities.Clear();
                label2.Text = $"Корзина (товарів: {cart.Commodities.Count})";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
