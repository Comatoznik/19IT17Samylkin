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
        public char F;
        public Form1()
        {
            InitializeComponent();

        }

        private void generation_Click(object sender, EventArgs e)
        {
            F = Convert.ToChar("*");
            label5.Text = Convert.ToString(F);

        }
        private void plus_Click(object sender, EventArgs e)
        {
            F = Convert.ToChar('+');
            label5.Text = Convert.ToString(F);
        }

        public void minus_Click(object sender, EventArgs e)
        {
            F = Convert.ToChar('-');
            label5.Text = Convert.ToString(F);
        }

        private void splitting_Click(object sender, EventArgs e)
        {
            F = Convert.ToChar('/');
            label5.Text = Convert.ToString(F);
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (F == '+')
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));
            if (F == '*')
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));
            if (F == '-')
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));
            if (F == '/')
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text));
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            F = '0';
        }
    }
}
