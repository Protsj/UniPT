using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.l5;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tab = new Tabulation();
            double xn = Convert.ToDouble(textBox1.Text),
                   xk = Convert.ToDouble(textBox2.Text),
                   h = Convert.ToDouble(textBox3.Text);
            tab.getList(xn, xk, h);
            listBox1.Items.Clear();
            for (int i = 0; i < tab.points.Count; i++)
            {
                listBox1.Items.Add($"x = {Math.Round(tab.points[i].X, 2).ToString()} " +
                                   $"y = {Math.Round(tab.points[i].Y, 2).ToString()} " +
                                   $"Цикл = {Math.Round(tab.points[i].Y_loop, 2).ToString()} " +
                                   $"Рекурсія = {Math.Round(tab.points[i].Y_rec, 2).ToString()}");
            }
        }
    }
}
