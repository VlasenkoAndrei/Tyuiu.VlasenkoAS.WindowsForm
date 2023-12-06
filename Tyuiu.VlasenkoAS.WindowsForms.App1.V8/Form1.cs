using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.VlasenkoAS.WindowsForms.App1.V8
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "0.00") 
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "0.00")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") 
            {
                textBox1.Text = "0.00";
                textBox1.ForeColor = Color.LightGray;
            } 
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "0.00";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;

            string inputFirst = textBox1.Text.Replace(".", ",");
            string inputSecond = textBox2.Text.Replace(".",",");

            if (double.TryParse(inputFirst, out x) && double.TryParse(inputSecond, out y) && x != 0.00 && y != 0.00)
            {
                if (radioButton1.Checked)
                {
                    z = x * Math.Log(x) + y / (Math.Cos(x) - x / 3);
                    textBox3.Text = z.ToString();
                }
                else if (radioButton2.Checked)
                {
                    z = (1 + Math.Pow(Math.Sin(x + y), 2)) / (2 + Math.Abs(x - 2 * x / (1 + Math.Pow(x, 2) * Math.Pow(y, 2))));
                    textBox3.Text = z.ToString();
                }
                else
                {
                    MessageBox.Show("Выберите одно из выражений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите корректные вещественные числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
