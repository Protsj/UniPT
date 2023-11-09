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
            Random random = new Random();
            dataGridView1.Rows.Clear();
            int n = Convert.ToInt16(textBox1.Text);
            double totalLandArea = 0;
            for (int i = 0; i < n; i++)
            {
                Bird b;
                int birdType = random.Next(3);
                if (birdType == 0)
                    b = new FlyingAndSwimmingBird("Качка", 8, 35);
                else if (birdType == 1)
                    b = new SwimmingBird("Пінгвін", 30);
                else
                    b = new RunningAndSwimmingBird("Ківі", 13.5, 53.1);
                dataGridView1.Rows.Add(b.getInfo());
                totalLandArea += b.getLandArea();
            }
            label2.Text = $"Площа всіх вольєрів: {totalLandArea}м2";
        }
    }
}
