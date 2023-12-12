using System;
using System.Drawing;
using System.Windows.Forms;
// using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.VlasenkoAS.WindowsForms.App1.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxValueX_Enter(object sender, EventArgs e)
        {
            if (textBoxValueX.Text == "0.00") 
            {
                textBoxValueX.Text = "";
                textBoxValueX.ForeColor = Color.Black;
            }
        }

        private void textBoxValueY_Enter(object sender, EventArgs e)
        {
            if (textBoxValueY.Text == "0.00")
            {
                textBoxValueY.Text = "";
                textBoxValueY.ForeColor = Color.Black;
            }
        }

        private void textBoxValueX_Leave(object sender, EventArgs e)
        {
            if (textBoxValueX.Text == "") 
            {
                textBoxValueX.Text = "0.00";
                textBoxValueX.ForeColor = Color.LightGray;
            } 
        }

        private void textBoxValueY_Leave(object sender, EventArgs e)
        {
            if (textBoxValueY.Text == "")
            {
                textBoxValueY.Text = "0.00";
                textBoxValueY.ForeColor = Color.LightGray;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double x, y, z;
            double denom = 0.0; // Знаменатель (denominator)
            string inputFirst = textBoxValueX.Text.Replace(".", ",");
            string inputSecond = textBoxValueY.Text.Replace(".",",");

            if (double.TryParse(inputFirst, out x) && double.TryParse(inputSecond, out y) && x != 0.00 && y != 0.00)
            {
                if (radioButtonFirstExpression.Checked)
                {
                    denom = Math.Cos(x) - x / 3;

                    if (denom != 0.0)
                    {
                        z = x * Math.Log(x) + y / denom;
                        textBoxValueExpression.Text = z.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Деление на 0 невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radioButtonSecondExpression.Checked)
                {
                    denom = 2 + Math.Abs(x - 2 * x / (1 + Math.Pow(x, 2) * Math.Pow(y, 2)));

                    if (denom != 0.0)
                    {
                        z = (1 + Math.Pow(Math.Sin(x + y), 2)) / denom;
                        textBoxValueExpression.Text = z.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Деление на 0 невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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
