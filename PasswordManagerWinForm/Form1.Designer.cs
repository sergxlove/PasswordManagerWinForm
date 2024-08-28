namespace PasswordManagerWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 52);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(877, 9);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 2;
            label2.Text = "Добавить";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(68, 68, 68);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(454, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "Поиск";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(152, 31);
            label1.TabIndex = 0;
            label1.Text = "Все карточки";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Location = new Point(12, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(435, 583);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(68, 68, 68);
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(116, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(577, 38);
            textBox2.TabIndex = 3;
            textBox2.Text = "Название";
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 71);
            label3.Name = "label3";
            label3.Size = new Size(180, 31);
            label3.TabIndex = 3;
            label3.Text = "Email или логин";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(68, 68, 68);
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.ForeColor = Color.Gray;
            textBox3.Location = new Point(20, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(727, 38);
            textBox3.TabIndex = 4;
            textBox3.Text = "Введите email или логин";
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 171);
            label4.Name = "label4";
            label4.Size = new Size(93, 31);
            label4.TabIndex = 5;
            label4.Text = "Пароль";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(68, 68, 68);
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.ForeColor = Color.Gray;
            textBox4.Location = new Point(20, 205);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(727, 38);
            textBox4.TabIndex = 6;
            textBox4.Text = "Введите пароль";
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.White;
            label10.Location = new Point(20, 280);
            label10.Name = "label10";
            label10.Size = new Size(44, 31);
            label10.TabIndex = 10;
            label10.Text = "Url";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(68, 68, 68);
            textBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox5.ForeColor = Color.Gray;
            textBox5.Location = new Point(20, 314);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(727, 38);
            textBox5.TabIndex = 11;
            textBox5.Text = "Введите url";
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.Enter += textBox5_Enter;
            textBox5.Leave += textBox5_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.White;
            label11.Location = new Point(20, 379);
            label11.Name = "label11";
            label11.Size = new Size(124, 31);
            label11.TabIndex = 12;
            label11.Text = "Описание ";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(68, 68, 68);
            textBox6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox6.ForeColor = Color.Gray;
            textBox6.Location = new Point(20, 413);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(727, 100);
            textBox6.TabIndex = 13;
            textBox6.Text = "Описание ...";
            textBox6.TextChanged += textBox6_TextChanged;
            textBox6.Enter += textBox6_Enter;
            textBox6.Leave += textBox6_Leave;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox2);
            panel3.Location = new Point(466, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(758, 583);
            panel3.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(20, 516);
            label9.Name = "label9";
            label9.Size = new Size(173, 20);
            label9.TabIndex = 20;
            label9.Text = "* Необязательное поле";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(20, 355);
            label8.Name = "label8";
            label8.Size = new Size(173, 20);
            label8.TabIndex = 19;
            label8.Text = "* Необязательное поле";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 246);
            label7.Name = "label7";
            label7.Size = new Size(156, 20);
            label7.TabIndex = 18;
            label7.Text = "* Обязательное поле";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 146);
            label6.Name = "label6";
            label6.Size = new Size(156, 20);
            label6.TabIndex = 17;
            label6.Text = "* Обязательное поле";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(116, 56);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 16;
            label5.Text = "* Обязательное поле";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(69, 69, 69);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.White;
            button2.Location = new Point(560, 530);
            button2.Name = "button2";
            button2.Size = new Size(159, 36);
            button2.TabIndex = 15;
            button2.Text = "Сбросить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(69, 69, 69);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(378, 530);
            button1.Name = "button1";
            button1.Size = new Size(159, 36);
            button1.TabIndex = 14;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 69, 69);
            ClientSize = new Size(1236, 665);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Password manager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox5;
        private Label label11;
        private TextBox textBox6;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}
