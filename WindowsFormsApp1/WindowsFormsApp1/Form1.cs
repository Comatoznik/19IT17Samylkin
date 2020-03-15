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
        int a, b;
        public Form1()
        {
            InitializeComponent();

        }

        private void generation_Click(object sender, EventArgs e)
        {
            {
                a = int.Parse(textBox1.Text);
                textBox1.Clear();
                temp = 1;
                label1.Text = "*";
                F = true;
            }


        }
        private void plus_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            temp = 2;
            textBox1.Clear();
            label1.Text = "+";
            F = true;

        }

        public void minus_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            temp = 3;
            textBox1.Clear();
            label1.Text ="-";
            F = true;

        }

        private void splitting_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            temp = 4;
            textBox1.Clear();
            label1.Text ="/";
            F = true;
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
            textBox1.Text+=0;
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

        private void calculate()
        {
            switch (temp)
            {
                case 1:
                    b = a * int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a + int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a - int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }
        }}
