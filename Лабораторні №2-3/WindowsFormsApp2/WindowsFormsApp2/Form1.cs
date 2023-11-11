using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Parallelogram parallelogram;
        Bow bow;
        Triangle triangle;
        public Form1()
        {
            InitializeComponent();

            Point[] points = { new Point(204, 20), new Point(201, 30), new Point(220, 30), new Point(223, 20) };
            parallelogram = new Parallelogram(points);

            points = new Point[] { new Point(224, 20), new Point(224, 30), new Point(234, 25), new Point(244, 20), new Point(244, 30) };
            bow = new Bow(points);

            points = new Point[] { new Point(250, 30), new Point(255, 20), new Point(260, 30) };
            triangle = new Triangle(points);
            triangle = new Triangle(points);

            SolidBrush sb1 = new SolidBrush(Color.Blue);
            SolidBrush sb2 = new SolidBrush(Color.Red);
            SolidBrush sb3 = new SolidBrush(Color.Green);
            Graphics g = pictureBox1.CreateGraphics();

            pictureBox1.Paint += (sender, e) =>
            {
                DrawShape(e.Graphics, parallelogram, sb1);
                DrawShape(e.Graphics, bow, sb2);
                DrawShape(e.Graphics, triangle, sb3);
            };
            pictureBox1.Invalidate();
        }
        private void DrawShape(Graphics g, Shape shape, SolidBrush brush)
        {
            Point[] points = shape.Points;
            PointF[] pointsF = new PointF[points.Length];
            for (int i = 0; i < points.Length; i++)
                pointsF[i] = new PointF(points[i].X, points[i].Y);

            g.FillPolygon(brush, pointsF);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(textBox1.Text);
                int n2 = Convert.ToInt32(textBox2.Text);
                int n3 = Convert.ToInt32(textBox3.Text);
                if (n3 == 0 || n3 < 0)
                    throw new Exception("Неможливо збільшити в 0 разів або число, що < 0!");
                int n4 = Convert.ToInt32(textBox4.Text);

                SolidBrush sb1 = new SolidBrush(Color.Blue);
                SolidBrush sb2 = new SolidBrush(Color.Red);
                SolidBrush sb3 = new SolidBrush(Color.Green);

                if (comboBox1.SelectedIndex == 0)
                    sb1 = new SolidBrush(Color.Green);
                else if (comboBox1.SelectedIndex == 1)
                    sb1 = new SolidBrush(Color.Blue);
                else if (comboBox1.SelectedIndex == 2)
                    sb1 = new SolidBrush(Color.Red);
                else if (comboBox1.SelectedIndex == 3)
                    sb1 = new SolidBrush(Color.Yellow);

                if (comboBox1.SelectedIndex == 0)
                    sb2 = new SolidBrush(Color.Green);
                else if(comboBox2.SelectedIndex == 1)
                    sb2 = new SolidBrush(Color.Blue);
                else if (comboBox2.SelectedIndex == 2)
                    sb2 = new SolidBrush(Color.Red);
                else if (comboBox2.SelectedIndex == 3)
                    sb2 = new SolidBrush(Color.Yellow);

                if (comboBox1.SelectedIndex == 0)
                    sb3 = new SolidBrush(Color.Green);
                else if(comboBox3.SelectedIndex == 1)
                    sb3 = new SolidBrush(Color.Blue);
                else if (comboBox3.SelectedIndex == 2)
                    sb3 = new SolidBrush(Color.Red);
                else if (comboBox3.SelectedIndex == 3)
                    sb3 = new SolidBrush(Color.Yellow);

                if (checkBox1.Checked)
                {
                    parallelogram.Move(n1, n2);
                    parallelogram.Scale(n3);
                    parallelogram.Rotate(n4);
                }
                if (checkBox2.Checked)
                {
                    bow.Move(n1, n2);
                    bow.Scale(n3);
                    bow.Rotate(n4);
                }
                if (checkBox3.Checked)
                {
                    triangle.Move(n1, n2);
                    triangle.Scale(n3);
                    triangle.Rotate(n4);
                }
                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.White);
                DrawShape(g, parallelogram, sb1);
                DrawShape(g, bow, sb2);
                DrawShape(g, triangle, sb3);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point[] points = { new Point(204, 20), new Point(201, 30), new Point(220, 30), new Point(223, 20) };
            parallelogram = new Parallelogram(points);

            points = new Point[] { new Point(224, 20), new Point(224, 30), new Point(234, 25), new Point(244, 20), new Point(244, 30) };
            bow = new Bow(points);

            points = new Point[] { new Point(250, 30), new Point(255, 20), new Point(260, 30) };
            triangle = new Triangle(points);

            SolidBrush sb1 = new SolidBrush(Color.Blue);
            SolidBrush sb2 = new SolidBrush(Color.Red);
            SolidBrush sb3 = new SolidBrush(Color.Green);
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            DrawShape(g, parallelogram, sb1);
            DrawShape(g, bow, sb2);
            DrawShape(g, triangle, sb3);
        }
    }
}
