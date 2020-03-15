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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Alef", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(7, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 67);
            this.textBox1.TabIndex = 0;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(324, 209);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(72, 56);
            this.button14.TabIndex = 25;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.generation_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(248, 209);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(72, 56);
            this.button15.TabIndex = 27;
            this.button15.Text = "/";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.splitting_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(248, 147);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(72, 56);
            this.button16.TabIndex = 29;
            this.button16.Text = "--";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.minus_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(325, 147);
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
            this.button3.Location = new System.Drawing.Point(243, 271);
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
            this.button4.Location = new System.Drawing.Point(248, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 56);
            this.button4.TabIndex = 34;
            this.button4.Text = "Результат";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.equal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 58);
            this.button1.TabIndex = 35;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.zero_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 56);
            this.button2.TabIndex = 37;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.two_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(166, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 56);
            this.button5.TabIndex = 39;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.six_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 147);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 56);
            this.button6.TabIndex = 41;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.four_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 209);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 56);
            this.button7.TabIndex = 43;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.one_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(166, 85);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 56);
            this.button8.TabIndex = 45;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.nine_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(88, 147);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 56);
            this.button9.TabIndex = 47;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.five_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(164, 209);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 56);
            this.button10.TabIndex = 49;
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.three_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(7, 85);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(72, 56);
            this.button11.TabIndex = 51;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.seven_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(88, 85);
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
            this.label1.Location = new System.Drawing.Point(340, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 40);
            this.label1.TabIndex = 53;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Калькулятор Самылкина";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

