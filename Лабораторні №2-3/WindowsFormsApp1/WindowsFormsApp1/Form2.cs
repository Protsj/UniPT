using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.l3;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
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
            Random random = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            var arr = new Vector[n * 2];
            for(int i = 0; i < arr.Length; i = i + 2)
            {
                arr[i] = new _2DVector(random.Next(-100, 100) / 10.0f, random.Next(-100, 100) / 10.0f);
                arr[i + 1] = new _3DVector(random.Next(10,200) / 10.0f);
            }
            double totalLength = 0;
            listBox1.Items.Clear();
            for(int i = 0; i < arr.Length; i++) 
            {
                listBox1.Items.Add($"{arr[i].ShowInfo()} Довжина: {arr[i].Length()}");
                totalLength += arr[i].Length();
            }
            label2.Text = $"Сумарна довжина векторів: {totalLength}";
        }
    }
}
