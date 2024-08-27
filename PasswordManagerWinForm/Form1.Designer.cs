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
            panel3 = new Panel();
            textBox6 = new TextBox();
            label11 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            textBox1.ForeColor = Color.White;
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
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
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
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(68, 68, 68);
            textBox6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(20, 423);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(727, 134);
            textBox6.TabIndex = 13;
            textBox6.Text = "Описание ...";
            textBox6.Enter += textBox6_Enter;
            textBox6.Leave += textBox6_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.White;
            label11.Location = new Point(20, 389);
            label11.Name = "label11";
            label11.Size = new Size(124, 31);
            label11.TabIndex = 12;
            label11.Text = "Описание ";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(68, 68, 68);
            textBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(20, 325);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(727, 38);
            textBox5.TabIndex = 11;
            textBox5.Text = "Введите url";
            textBox5.Enter += textBox5_Enter;
            textBox5.Leave += textBox5_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.White;
            label10.Location = new Point(20, 291);
            label10.Name = "label10";
            label10.Size = new Size(44, 31);
            label10.TabIndex = 10;
            label10.Text = "Url";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.White;
            label9.Location = new Point(621, 248);
            label9.Name = "label9";
            label9.Size = new Size(126, 31);
            label9.TabIndex = 3;
            label9.Text = "Надёжный";
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(60, 60, 60);
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.White;
            label8.Location = new Point(446, 258);
            label8.Name = "label8";
            label8.Size = new Size(136, 14);
            label8.TabIndex = 9;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(60, 60, 60);
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.White;
            label7.Location = new Point(304, 258);
            label7.Name = "label7";
            label7.Size = new Size(136, 14);
            label7.TabIndex = 8;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(60, 60, 60);
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(162, 258);
            label6.Name = "label6";
            label6.Size = new Size(136, 14);
            label6.TabIndex = 7;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(60, 60, 60);
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 258);
            label5.Name = "label5";
            label5.Size = new Size(136, 14);
            label5.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(68, 68, 68);
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(20, 207);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(727, 38);
            textBox4.TabIndex = 6;
            textBox4.Text = "Введите пароль";
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 173);
            label4.Name = "label4";
            label4.Size = new Size(93, 31);
            label4.TabIndex = 5;
            label4.Text = "Пароль";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(68, 68, 68);
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(20, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(727, 38);
            textBox3.TabIndex = 4;
            textBox3.Text = "Введите email или логин";
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
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
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(68, 68, 68);
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(116, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(577, 38);
            textBox2.TabIndex = 3;
            textBox2.Text = "Название";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Location = new Point(12, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(435, 583);
            flowLayoutPanel1.TabIndex = 0;
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
        private Panel panel3;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox6;
        private Label label11;
        private TextBox textBox5;
        private Label label10;
    }
}
