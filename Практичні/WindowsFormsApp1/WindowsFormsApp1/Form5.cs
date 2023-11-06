using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1.p3;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
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
            int i1, i2;
            i1 = Convert.ToInt32(textBox1.Text);
            i2 = Convert.ToInt32(textBox2.Text);
            EvenNumSumInInterval ensii = new EvenNumSumInInterval(i1, i2);
            int res = ensii.GetSumOfEvenNums();
            label3.Text = $"Сума парних чисел: {res.ToString()}";
        }
    }
}
