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
            label4.Hide();
            label8.Hide();
            textBox3.Hide();
            textBox4.Hide();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label4.Show();
                label8.Show();
                label8.Text = "Спеціальність:";
                textBox3.Show();
                textBox4.Show();
                textBox3.Clear();
                textBox4.Text = "0";
            }
            else
            {
                label4.Hide();
                label8.Hide();
                textBox3.Hide();
                textBox4.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name;
                float s = 0;
                name = textBox1.Text;
                s = (float)Convert.ToDouble(textBox2.Text);

                if (checkBox1.Checked)
                {
                    string specialty;
                    float m = 0;
                    specialty = textBox3.Text;
                    if (string.IsNullOrWhiteSpace(specialty) || string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        MessageBox.Show("Будь ласка, заповніть поля (спеціальність/+m).");
                        return;
                    }
                    m = (float)Convert.ToDouble(textBox4.Text);
                    Master master = new Master(name, s, specialty, m);
                    label5.Text = $"Ім'я студента: {master.Name}";
                    label6.Text = $"Середній бал: {master.S}";
                    label7.Text = $"Стипендія: {master.scholarship()}";
                    label8.Text = $"Спеціальність: {master.Specialty}";
                }
                else
                {
                    Student student = new Student(name, s);
                    label5.Text = $"Ім'я студента: {student.Name}";
                    label6.Text = $"Середній бал: {student.S}";
                    label7.Text = $"Стипендія: {student.scholarship()}";
                }
            }
            catch
            {
                MessageBox.Show("Будь ласка, заповніть всі обов'язкові поля (Ім'я, середній бал...)");
            }
        }
    }
}
