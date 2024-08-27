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
            TEnter((TextBox)sender, "t1");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TLeave((TextBox)sender, "t1");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            TEnter((TextBox)sender, "t2");
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            TLeave((TextBox)sender, "t2");
        }

        private void TEnter(TextBox selectTextbox, string key)
        {
            if (selectTextbox.Text == defText.GetDefaultText(key))
            {
                selectTextbox.Text = string.Empty;
            }
        }

        private void TLeave(TextBox selectTextbox, string key)
        {
            if (selectTextbox.Text.Length == 0)
            {
                selectTextbox.Text = defText.GetDefaultText(key);
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            TEnter((TextBox)sender, "t3");
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            TLeave((TextBox)sender, "t3");
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            TEnter((TextBox)sender, "t4");
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            TLeave((TextBox)sender, "t4");
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            TEnter((TextBox)sender, "t5");
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            TLeave((TextBox)sender, "t5");
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            TEnter((TextBox)sender, "t6");
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            TLeave((TextBox)sender, "t6");
        }
    }
}
