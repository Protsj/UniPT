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
    public partial class Form3 : Form
    {
        public Form3()
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
            try
            {
                int xl = 0, yl = 0;
                xl = Convert.ToInt32(textBox1.Text);
                yl = Convert.ToInt32(textBox2.Text);
                Array2D a2d = new Array2D(xl, yl);
                DataGridViewTextBoxColumn dv;
                for (int i = 0; i < yl; i++)
                {
                    dv = new DataGridViewTextBoxColumn();
                    dv.Width = 40;
                    dataGridView1.Columns.Add(dv);
                }
                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = a2d.X_length;
                dataGridView1.ColumnCount = a2d.Y_length;
                for (int i = 0; i < a2d.X_length; i++)
                    for (int j = 0; j < a2d.Y_length; j++)
                        dataGridView1.Rows[i].Cells[j].Value = a2d[i, j].ToString();
                a2d.FindMaxElement(out int maxElement, out string p);
                label3.Text = $"Найбільший елемент - це {maxElement}. Розатшований {p}"; 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
