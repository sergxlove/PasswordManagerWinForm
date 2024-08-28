using PasswordManagerWinForm.Contracts;

namespace PasswordManagerWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DefaultTextForTextBox defText = new DefaultTextForTextBox();

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBoxEnter((TextBox)sender, "t1");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBoxLeave((TextBox)sender, "t1");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            TextBoxEnter((TextBox)sender, "t2");
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            TextBoxLeave((TextBox)sender, "t2");
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            TextBoxEnter((TextBox)sender, "t3");
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            TextBoxLeave((TextBox)sender, "t3");
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            TextBoxEnter((TextBox)sender, "t4");
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            TextBoxLeave((TextBox)sender, "t4");
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            TextBoxEnter((TextBox)sender, "t5");
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            TextBoxLeave((TextBox)sender, "t5");
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            TextBoxEnter((TextBox)sender, "t6");
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            TextBoxLeave((TextBox)sender, "t6");
        }

        private void TextBoxEnter(TextBox selectTextbox, string key)
        {
            if (selectTextbox.Text == defText.GetDefaultText(key))
            {
                selectTextbox.Text = string.Empty;
                selectTextbox.ForeColor = Color.White;
            }
        }

        private void TextBoxLeave(TextBox selectTextbox, string key)
        {
            if (selectTextbox.Text.Length == 0)
            {
                selectTextbox.Text = defText.GetDefaultText(key);
                selectTextbox.ForeColor = Color.Gray;
            }
        }

        private void TextBoxValidation(ParamsValidationObject prop)
        {
            if (prop.selectTextbox.Text != prop.defNameTextBox)
            {
                if (prop.selectTextbox.Text.Length < prop.minSymbol)
                {
                    prop.messageLabel.Text = $"Должно быть более {prop.minSymbol} символов.";
                    prop.messageLabel.ForeColor = Color.Red;
                }
                else if (prop.selectTextbox.Text.Length > prop.maxSymbol)
                {
                    prop.messageLabel.Text = $"Превышено максимльное число сиволов - {prop.maxSymbol}";
                    prop.messageLabel.ForeColor = Color.Red;
                }
                else
                {
                    prop.messageLabel.Text = "Введено";
                    prop.messageLabel.ForeColor = Color.Green;
                }
            }
            else
            {
                prop.messageLabel.Text = prop.defNameLabel;
                prop.messageLabel.ForeColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = defText.GetDefaultText("t2");
            textBox3.Text = defText.GetDefaultText("t3");
            textBox4.Text = defText.GetDefaultText("t4");
            textBox5.Text = defText.GetDefaultText("t5");
            textBox6.Text = defText.GetDefaultText("t6");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ParamsValidationObject prop = new
                ((TextBox)sender,
                label5,
                20,
                3,
                defText.GetDefaultText("t2"),
                "*Обязательное поле"
                );
            TextBoxValidation(prop);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ParamsValidationObject prop = new
                ((TextBox)sender,
                label6,
                20,
                3,
                defText.GetDefaultText("t3"),
                "*Обязательное поле"
                );
            TextBoxValidation(prop);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ParamsValidationObject prop = new
                ((TextBox)sender,
                label7,
                20,
                3,
                defText.GetDefaultText("t4"),
                "*Обязательное поле"
                );
            TextBoxValidation(prop);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ParamsValidationObject prop = new
                ((TextBox)sender,
                label8,
                20,
                3,
                defText.GetDefaultText("t5"),
                "*Необязательное поле"
                );
            TextBoxValidation(prop);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ParamsValidationObject prop = new
                ((TextBox)sender,
                label9,
                150,
                3,
                defText.GetDefaultText("t6"),
                "*Необязательное поле"
                );
            TextBoxValidation(prop);
        }
    }
}
