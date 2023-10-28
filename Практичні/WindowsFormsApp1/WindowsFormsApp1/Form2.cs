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
            dataGridView1.Rows.Clear();
            try
            {
                float t = (float)Convert.ToDouble(textBox1.Text);
                TemperatureArrays a = new TemperatureArrays(t);
                for (int i = 0; i < a.Size; i++)
                    dataGridView1.Rows.Add(a[i].ToString());
                (int, float) items = a.countt();
                if (items.Item1 != 14 && items.Item2 != 14)
                    label4.Text = $"О { (items.Item1 + 8)} годині була зафіксована від'ємна температура {items.Item2} °C";
                else
                    label4.Text = "Від'ємної температури не було зафіксовано.";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
