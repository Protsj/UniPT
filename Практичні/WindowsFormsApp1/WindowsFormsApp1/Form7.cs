using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.p5;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        Students students = new Students();
        string path = "data.txt";

        public void show(DataGridView dg)
        {
            dg.Rows.Clear();
            foreach (Student s in students.students)
            {
                string apss = "";
                foreach (int a in s.Appraisals)
                    apss += a.ToString() + " ";
                dg.Rows.Add(s.LastName, s.Faculty, s.Course, s.Group, apss);
            }
        }
        public Form7()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int[] aps = new int[5] { Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text) };
                if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null ||
                   textBox4.Text == null || textBox5.Text == null || textBox6.Text == null ||
                   textBox7.Text == null || textBox8.Text == null || textBox9.Text == null)
                    throw new Exception("Не всі поля заповнені!");
                if (!IsStudentAlreadyExists(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), aps))
                {
                    Student student = new Student(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), aps);
                    students.add(student);
                    string apss = "";
                    foreach (int a in aps)
                        apss += a.ToString() + " ";
                    dataGridView2.Rows.Add(students.students[students.students.Count - 1].LastName,
                                           students.students[students.students.Count - 1].Faculty,
                                           students.students[students.students.Count - 1].Course,
                                           students.students[students.students.Count - 1].Group,
                                           apss);
                }
                else
                    MessageBox.Show("Такий студент вже існує!");
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }

        }

        private bool IsStudentAlreadyExists(string lastName, string faculty, int course, int group, int[] appraisals)
        {
            foreach (Student existingStudent in students.students)
            {
                if (existingStudent.LastName == lastName &&
                    existingStudent.Faculty == faculty &&
                    existingStudent.Course == course &&
                    existingStudent.Group == group &&
                    Enumerable.SequenceEqual(existingStudent.Appraisals, appraisals))
                    return true;
            }
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                students.sort();
                foreach (Student s in students.students)
                {
                    if (s.Appraisals.Contains(2))
                    {
                        int[] aps = s.Appraisals;
                        string apss = "";
                        foreach (int ap in aps)
                            apss += ap.ToString() + " ";
                        dataGridView1.Rows.Add(s.LastName, s.Faculty, s.Course, s.Group, apss);
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            students.readFile(path);
            show(dataGridView2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            students.writeFile(path);
            MessageBox.Show("Дані були записані до файлу!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var i = dataGridView2.CurrentRow.Index;
            students.remove(students.students[i]);
            show(dataGridView2);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            students.sort();
            show(dataGridView3);
        }
    }
}
