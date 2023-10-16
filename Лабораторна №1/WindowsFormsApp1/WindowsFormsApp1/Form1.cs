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
            Quadrangle q1, q2, q3;
            int s1, s2, s3, s4, a, b;

            try
            {
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                s3 = Convert.ToInt32(textBox3.Text);
                s4 = Convert.ToInt32(textBox4.Text);
                a = Convert.ToInt32(textBox5.Text);
                b = Convert.ToInt32(textBox6.Text);

                q1 = new Quadrangle(s1, s2, s3, s4);
                q2 = new Quadrangle(a, b);
                q3 = new Quadrangle();

                if (q1.IsParallelogram())
                    label18.Text = "Чи є чотирикутник параллелограммом: Так";
                else
                    label18.Text = "Чи є чотирикутник параллелограммом: Ні";

                if (q2.IsParallelogram())
                    label19.Text = "Чи є чотирикутник параллелограммом: Так";
                else
                    label19.Text = "Чи є чотирикутник параллелограммом: Ні";

                if (q3.IsParallelogram())
                    label20.Text = "Чи є чотирикутник параллелограммом: Так";
                else
                    label20.Text = "Чи є чотирикутник параллелограммом: Ні";

                label10.Text = "s1 = " + q2.S1;
                label11.Text = "s2 = " + q2.S2;
                label12.Text = "s3 = " + q2.S3;
                label13.Text = "s4 = " + q2.S4;
                label14.Text = "s1 = " + q3.S1;
                label15.Text = "s2 = " + q3.S2;
                label16.Text = "s3 = " + q3.S3;
                label17.Text = "s4 = " + q3.S4;

            }
            catch
            {
                MessageBox.Show("Помилка при введенні даних!");
            }
        }
    }
}
