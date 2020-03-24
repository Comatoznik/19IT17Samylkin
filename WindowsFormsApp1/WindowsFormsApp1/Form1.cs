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
        public bool F = true;
        public int temp;
        int a;
        double b;
        public Form1()
        {
            InitializeComponent();

        }

        private void generation_Click(object sender, EventArgs e)
        { try
            {
                {
                    a = int.Parse(textBox1.Text);
                    textBox1.Clear();
                    temp = 1;
                    label1.Text = "*";
                    F = true;
                }
            }
            catch (FormatException)
            {
                textBox1.Text = "Неверный формат ввода!";
            }


        }
        private void plus_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                temp = 2;
                textBox1.Clear();
                label1.Text = "+";
                F = true;
            }
            catch (FormatException)
            {
                textBox1.Text = "Неверный формат ввода!";
            }

        }

        public void minus_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                temp = 3;
                textBox1.Clear();
                label1.Text = "-";
                F = true;
            }
            catch (FormatException)
            {
                textBox1.Text = "Неверный формат ввода!";
            }
        }

        private void splitting_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                temp = 4;
                textBox1.Clear();
                label1.Text = "/";
                F = true;
            }
            catch (FormatException)
            {
                textBox1.Text = "Неверный формат ввода!";
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            calculate();
            textBox1.Text = Convert.ToString(b);
        }
        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            F = true;
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void calculate()
        {
                switch (temp)
                {

                    case 1:
                    try
                    {
                        b = a * int.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    catch (FormatException)
                    {
                        textBox1.Text = "Неверный формат ввода!";
                    }
                    
                    break;
                    case 2:
                    try
                    {
                        b = a + int.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    catch(FormatException)
                    {
                        textBox1.Text = "Неверный формат ввода!";
                    }
                        break;
                    case 3:
                    try
                    {
                        b = a - int.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    catch(FormatException)
                    {
                        textBox1.Text = "Неверный формат ввода!";
                    }
                    break;
                    
                    case 4:
                    try
                    {
                        b = a / int.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    catch(DivideByZeroException)
                    {
                     
                    }
                        break;

                    default:
                        break;

                }
            }

        private void sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                temp = 5;
                b = Math.Sqrt(a);
                textBox1.Text = Convert.ToString(b);
                label1.Text = "sqrt";
                F = true;
            }
            catch (FormatException)
            {
                textBox1.Text = "Неверный формат ввода!";
            }

        }

        private void sin_Click(object sender, EventArgs e)
        { try
            {
                a = int.Parse(textBox1.Text);
                b = Math.Sin(a);
                textBox1.Text = Convert.ToString(b);
                label1.Text = "sin";
                F = true;
            }
            catch(FormatException)
            {
                textBox1.Text = "Неверный формат ввода!";
            }
        }

        private void cos_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                b = Math.Cos(a);
                textBox1.Text = Convert.ToString(b);
                label1.Text = "cos";
                F = true;
            }
            catch (FormatException)
            {
                textBox1.Text = "Неверный формат ввода!";
            }
        }

        private void tan_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                b = Math.Tan(a);
                textBox1.Text = Convert.ToString(b);
                label1.Text = "tg";
                F = true;
            }
            catch(FormatException)
            {
                textBox1.Text = "Неверный формат ввода!";
            }
        }

        private void log_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                b = Math.Log10(a);
                textBox1.Text = Convert.ToString(b);
                label1.Text = "log(10)";
                F = true;
            }
            catch(FormatException)
            {
                textBox1.Text = "Неверный формат ввода!";
            }
        }

        private void pow_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                b = Math.Pow(a, 2);
                textBox1.Text = Convert.ToString(b);
                label1.Text = "^2";
                F = true;
            }
            catch
            {
                textBox1.Text = "Неверный формат ввода!";
            }
        }

        private void exp_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                b = Math.Exp(a);
                textBox1.Text = Convert.ToString(b);
                label1.Text = "exp";
                F = true;
            }
            catch(FormatException)
            {
                textBox1.Text = "Неверный формат ввода!"; 
            }
        }

    }
}
