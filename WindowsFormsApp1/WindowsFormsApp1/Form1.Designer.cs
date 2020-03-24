namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button24 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Alef", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(27, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(474, 109);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(272, 364);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(72, 56);
            this.button14.TabIndex = 25;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.generation_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(272, 426);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(72, 56);
            this.button15.TabIndex = 27;
            this.button15.Text = "/";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.splitting_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(354, 364);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(72, 56);
            this.button16.TabIndex = 29;
            this.button16.Text = "--";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.minus_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(354, 426);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(72, 56);
            this.button17.TabIndex = 31;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.plus_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button3.Location = new System.Drawing.Point(272, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 58);
            this.button3.TabIndex = 32;
            this.button3.Text = "Очистка";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.clear_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(27, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 56);
            this.button4.TabIndex = 34;
            this.button4.Text = "Результат";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.equal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 61);
            this.button1.TabIndex = 35;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.zero_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 56);
            this.button2.TabIndex = 37;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.two_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(183, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 56);
            this.button5.TabIndex = 39;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.six_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(27, 361);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 56);
            this.button6.TabIndex = 41;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.four_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 423);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 56);
            this.button7.TabIndex = 43;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.one_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(185, 299);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 56);
            this.button8.TabIndex = 45;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.nine_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(105, 361);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 56);
            this.button9.TabIndex = 47;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.five_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(183, 423);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 56);
            this.button10.TabIndex = 49;
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.three_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(27, 299);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(72, 56);
            this.button11.TabIndex = 51;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.seven_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(105, 299);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(72, 56);
            this.button12.TabIndex = 52;
            this.button12.Text = "8";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.eight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(257, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 40);
            this.label1.TabIndex = 53;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-8, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 586);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button19);
            this.tabPage1.Controls.Add(this.button20);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.button18);
            this.tabPage1.Controls.Add(this.button21);
            this.tabPage1.Controls.Add(this.button22);
            this.tabPage1.Controls.Add(this.button23);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button16);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button15);
            this.tabPage1.Controls.Add(this.button17);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button14);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(515, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Простой";
            this.tabPage1.UseVisualStyleBackColor = true;

            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(432, 488);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(69, 58);
            this.button19.TabIndex = 57;
            this.button19.Text = "sqrt";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(432, 426);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(69, 56);
            this.button20.TabIndex = 58;
            this.button20.Text = "exp";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.exp_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(432, 364);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(69, 53);
            this.button13.TabIndex = 55;
            this.button13.Text = "sin";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.sin_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(432, 299);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(69, 56);
            this.button18.TabIndex = 56;
            this.button18.Text = "cos";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.cos_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(354, 299);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(72, 59);
            this.button21.TabIndex = 59;
            this.button21.Text = "tg";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.tan_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(272, 299);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(72, 59);
            this.button22.TabIndex = 60;
            this.button22.Text = "Log(10)";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.log_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(272, 237);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(229, 56);
            this.button23.TabIndex = 61;
            this.button23.Text = "x^2";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.pow_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.button24);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Строковый";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(105, 332);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 265);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(107, 196);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(385, 327);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(99, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(382, 260);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(102, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(380, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(105, 22);
            this.textBox3.TabIndex = 2;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(135, 110);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(220, 39);
            this.button24.TabIndex = 1;
            this.button24.Text = "button24";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(503, 84);
            this.textBox2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MintCream;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(515, 557);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Конвертер";

            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 759);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Калькулятор Самылкина";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TextBox textBox2;
    }
}

