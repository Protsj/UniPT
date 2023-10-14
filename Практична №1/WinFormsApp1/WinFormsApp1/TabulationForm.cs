using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TabulationForm : Form
    {
        public TabulationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabulation tab = new Tabulation();
            double xn, xk, xh, a;
            xn = Convert.ToDouble(this.textBox1.Text);
            xk = Convert.ToDouble(this.textBox2.Text);
            xh = Convert.ToDouble(this.textBox3.Text);
            a = Convert.ToDouble(this.textBox4.Text);
            dataGridView1.Rows.Clear();
            tab.tabulate(xn, xk, xh, a);
            for (int i = 0; i < tab.n; i++)
                dataGridView1.Rows.Add(Math.Round(tab.mat[i, 0], 2).ToString(), Math.Round(tab.mat[i, 1], 3).ToString());
        }
    }
}
