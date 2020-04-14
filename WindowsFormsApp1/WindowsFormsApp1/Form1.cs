﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public bool F = true;
        public int temp;
        int a;
        double b;
        int c;
        public Form1() => InitializeComponent();

        private void generation_Click(object sender, EventArgs e)
        {
            try
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
                label1.Text = "Неверный формат ввода!";
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
                label1.Text = "Неверный формат ввода!";
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
                label1.Text = "Неверный формат ввода!";
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
                label1.Text = "Неверный формат ввода!";
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
                        label1.Text = "Неверный формат ввода!";
                    }

                    break;
                case 2:
                    try
                    {
                        b = a + int.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    catch (FormatException)
                    {
                        label1.Text = "Неверный формат ввода!";
                    }
                    break;
                case 3:
                    try
                    {
                        b = a - int.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    catch (FormatException)
                    {
                        label1.Text = "Неверный формат ввода!";
                    }
                    break;

                case 4:
                    try
                    {
                        b = a / int.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    catch (DivideByZeroException)
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
                label1.Text = "Неверный формат ввода!";
            }

        }

        private void sin_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                b = Math.Sin(a);
                textBox1.Text = Convert.ToString(b);
                label1.Text = "sin";
                F = true;
            }
            catch (FormatException)
            {
                label1.Text = "Неверный формат ввода!";
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
                label1.Text = "Неверный формат ввода!";
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
            catch (FormatException)
            {
                label1.Text = "Неверный формат ввода!";
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
            catch (FormatException)
            {
                label1.Text = "Неверный формат ввода!";
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
                label1.Text = "Неверный формат ввода!";
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
            catch (FormatException)
            {
                label1.Text = "Неверный формат ввода!";
            }
        }

        private void dvoichnaya_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                c = int.Parse(textBox1.Text);
                string result = Convert.ToString((int)c, 2);
                textBox1.Text = result;
            }
            catch (FormatException)
            {
                label1.Text = ("Число должно быть больше нуля!");
            }
        }

        private void vosmerichnaya_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                c = int.Parse(textBox1.Text);
                string result = Convert.ToString((int)c, 8);
                textBox1.Text = result;
            }
            catch (FormatException)
            {
                label1.Text = ("Число должно быть больше нуля!");
            }

        }

        private void shestnadtsaterichnaya_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                c = int.Parse(textBox1.Text);
                string result = Convert.ToString((int)c, 16);
                textBox1.Text = result;
            }
            catch (FormatException)
            {
                label1.Text = ("Число должно быть больше нуля!");
            }


        }

        private void desyatichnaya_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                c = int.Parse(textBox1.Text);
                string result = Convert.ToString((int)c, 10);
                textBox1.Text = result;
            }
            catch (FormatException)
            {
                label1.Text = ("Число должно быть больше нуля!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string a = textBox2.Text.Length.ToString();
            label3.Text = $"Длина строки:{a}";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToUpper_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = textBox2.Text.ToUpper();
        }

        private void ToLower_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = textBox2.Text.ToLower();
        }

        private void stats_CheckedChanged(object sender, EventArgs e)
        {
            {
                int vowel = 0;
                int consonant = 0;
                List<Char> vowels = new List<char>() { 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ё', 'ю' };
                List<Char> consonants = new List<char>()
                { 'ц', 'к', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ф', 'в', 'п'
                , 'р', 'л', 'д', 'ж', 'ч', 'с', 'м', 'т', 'б' };
                foreach (char chr in textBox2.Text)
                {
                    if (vowels.Contains(chr))
                    {
                        vowel++;
                    }
                    if (consonants.Contains(chr))
                    {
                        consonant++;
                    }
                }
                string input = textBox2.Text;
                int Letter = 0;
                int Digit = 0;
                for (int i = 0; i < input.Length; i++)
                {

                    if (char.IsLetter(input[i]))
                        Letter++;
                    if (char.IsDigit(input[i]))
                        Digit++;
                }
                label6.Text = ("Букв : " + Letter.ToString());
                label7.Text = ("Цифр : " + Digit.ToString());
                label8.Text = ("Строк : " + textBox2.Lines.Length);
                label9.Text = ("Гласных : " + vowel.ToString());
                label10.Text = ("Согласных : " + consonant.ToString());


            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {// нахождение ошибок в строке
            string text = textBox2.Text;
            string[] trues = new string[] { "жи", "ши", "ча", "ща", "чу", "щу" };
            string[] errors = new string[] { "жы", "шы", "чя", "щя", "чю", "щю" };
            for (int i = 0; i < textBox2.Text.Length; i++)// перебираем введенные данные
            {
                for (int j = 0; j < errors.Length; j++) // перебираем ошибки
                {
                    try
                    {
                        if (textBox2.Text.Contains(errors[j])) // проверка на наличие ошибок
                            text = textBox2.Text.Replace(errors[j], trues[j]); // если они есть, заменяем их
                        textBox6.Text = text;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Строка не может быть пустой!");
                    }

                }
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            string[] str = new string[] { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять" };
            string[] num = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                    try
                    {
                        if (textBox2.Text.Contains(str[j]))
                            text = textBox2.Text.Replace(str[j], num[j]);
                        textBox6.Text = text;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Строка не может быть пустой!");
                    }
                // преобразование слов в цифры
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            text = textBox2.Text.Substring(5); // извлечение подстроки
            textBox6.Text = text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == 0)
                label16.Text = 10.ToString();
            if (listBox2.SelectedIndex == 1)
                label16.Text = 6.ToString();
            if (listBox2.SelectedIndex == 2)
                label16.Text = 3.ToString();
            if (listBox2.SelectedIndex == 3)
                label16.Text = 15.ToString();
            if (listBox2.SelectedIndex == 4)
                label16.Text = 20.ToString();
            if (listBox2.SelectedIndex == 5)
                label16.Text = 0.ToString();
            if (listBox1.SelectedIndex == 0)
                label15.Text = 32.70.ToString();
            if (listBox1.SelectedIndex == 1)
                label15.Text = 42.20.ToString();
            if (listBox1.SelectedIndex == 2)
                label15.Text = 48.90.ToString();
            if (listBox1.SelectedIndex == 3)
                label15.Text = 45.50.ToString();
            try
            {
                int input = int.Parse(textBox3.Text);
                double fuel = Convert.ToDouble(label15.Text);
                double ras = double.Parse(label16.Text);


                if (checkBox1.Checked)
                    ras = ras * 0.7;
                if (checkBox2.Checked)
                    ras = ras * 1.20;
                textBox4.Text = Math.Round((ras / input) * fuel).ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Введенная строка имела неверный формат");
            }
        }
        private void clear_Click_1(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            label15.Text = "";
            label16.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            listBox1.SelectedItem = default;
            listBox2.SelectedItem = default;
        }
    }
}