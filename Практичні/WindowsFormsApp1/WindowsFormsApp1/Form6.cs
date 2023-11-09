using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.p4;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
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
            PointInCircle p = new PointInCircle();
            FileWrite fw = new FileWrite();
            FileRead fr = new FileRead();
            ShowArray s = new ShowArray();
            string rpath = @"read.txt";
            string wpath = @"write.txt";
            fr.read(rpath, p);
            fw.write(wpath, p);
            label2.Text = $"{s.writeArray(p.x)}\n{s.writeArray(p.y)}";
            bool inCircle = p.pointsAreInCircle();
            label3.Text = $"Всі точки належать колу з радіусом 2 і з центром в точці (1,1): {(inCircle ? "Так" : "Ні")}";
        }
    }
}
