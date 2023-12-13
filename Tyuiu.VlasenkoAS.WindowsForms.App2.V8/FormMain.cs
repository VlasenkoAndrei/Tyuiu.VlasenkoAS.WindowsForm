using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.VlasenkoAS.WindowsForms.App2.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxValueStart_Enter(object sender, EventArgs e)
        {
            if (textBoxValueStart.Text == "0")
            {
                textBoxValueStart.Text = "";
                textBoxValueStart.ForeColor = Color.Black;
            }
        }

        private void textBoxValueEnd_Enter(object sender, EventArgs e)
        {
            if (textBoxValueEnd.Text == "0")
            {
                textBoxValueEnd.Text = "";
                textBoxValueEnd.ForeColor = Color.Black;
            }
        }

        private void textBoxValueStart_Leave(object sender, EventArgs e)
        {
            if (textBoxValueStart.Text == "")
            {
                textBoxValueStart.Text = "0";
                textBoxValueStart.ForeColor = Color.LightGray;
            }
        }

        private void textBoxValueEnd_Leave(object sender, EventArgs e)
        {
            if (textBoxValueEnd.Text == "")
            {
                textBoxValueEnd.Text = "0";
                textBoxValueEnd.ForeColor = Color.LightGray;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double start, end;
            int y = 0;

            string inputFirst = textBoxValueStart.Text;
            string inputSecond = textBoxValueEnd.Text;

            // Проверяем, что оба значения являются натуральными числами
            if (double.TryParse(inputFirst, out start) && double.TryParse(inputSecond, out end) && start % 1 == 0 && end % 1 == 0)
            {
                if (start < end)
                {
                    // Cтроим график в Chart
                    chartVisualizeExpression .Series[0].Points.Clear();

                    for (int i = (int)start; i <= (int)end; i++)
                    {
                        y = (int)(i / (Math.Cos(i) - i / 3) + (Math.Sin(Math.Pow(i, 2)) + Math.Cos(i)) / (Math.Cos(i) - Math.Sin(i)) * Math.Tan(i));

                        chartVisualizeExpression .Series[0].Points.AddXY(i, y);
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
