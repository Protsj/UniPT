using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
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
            chart1.Series[0].Points.Clear();
            tab.tabulate(xn, xk, xh, a);
            for (int i = 0; i < tab.n; i++)
            {
                dataGridView1.Rows.Add(Math.Round(tab.mat[i, 0], 2).ToString(), Math.Round(tab.mat[i, 1], 3).ToString());
                chart1.Series[0].Points.AddXY(tab.mat[i, 0], tab.mat[i, 1]);
            }
        }

        private void одновимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void двовимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void unitTestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void інтервалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void точкиВКоліToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }
    }
}
