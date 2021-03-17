using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовой_проект
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form2 frm2 = new Form2();
            Form1 frm1 = new Form1();
            frm1.Close();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)//кнопка расчета
        {
            try
            {
                int i = Convert.ToInt32(textBox2.Text);
                int j = Convert.ToInt32(textBox2.Text);
                int sum = 0;
                int[,] matrix = new int[i, j];
                for (i = 0; i < Convert.ToInt32(textBox2.Text); i++)
                {
                    for (j = 0; j < Convert.ToInt32(textBox2.Text); j++)
                    {
                        matrix[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
                        sum += matrix[i, j];
                    }
                }
                label2.Text = sum.ToString();
            }
            catch (FormatException) {
                MessageBox.Show("Введите корректные данные!");
            }
           
        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//кнопка фомирования таблицы
        {
            try
            {
                for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].HeaderCell.Value = "E" + i;
                }
            }
            catch (FormatException) {
                MessageBox.Show("Введите число!");
            }
           
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
