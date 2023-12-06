using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double start, end;
            int y = 0;

            string inputFirst = textBox1.Text;
            string inputSecond = textBox2.Text;

            // Проверяем, что оба значения являются натуральными числами
            if (double.TryParse(inputFirst, out start) && double.TryParse(inputSecond, out end) && start % 1 == 0 && end % 1 == 0)
            {
                if (start < end)
                {
                    // Cтроим график в Chart
                    chart1.Series[0].Points.Clear();

                    for (int i = (int)start; i <= (int)end; i++)
                    {
                        y = (int)(i / (Math.Cos(i) - i / 3) + (Math.Sin(Math.Pow(i, 2)) + Math.Cos(i)) / (Math.Cos(i) - Math.Sin(i)) * Math.Tan(i));

                        chart1.Series[0].Points.AddXY(i, y);
                    }
                }
                else
                {
                    MessageBox.Show("Значение начало диапазона должно быть меньше конечного значения");
                }

            }
            else
            {
                MessageBox.Show("Введите корректные натуральыне числа");
            }

        }
    }
}
