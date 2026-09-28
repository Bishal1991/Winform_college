using System;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int add = num1 + num2;
            label3.Text = $"the sum of {num1} and {num2} is {add}";
            label3.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int add = num1 - num2;
            label3.Text = $"the subtraction of {num1} and {num2} is {add}";
            label3.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int add = num1 * num2;
            label3.Text = $"the multiply of {num1} and {num2} is {add}";
            label3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int add = num1 / num2;
            label3.Text = $"the divide of {num1} and {num2} is {add}";
            label3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Source - https://stackoverflow.com/q/34826980
            // Posted by Attila Alan, modified by community. See post 'Timeline' for change history
            // Retrieved 2026-09-23, License - CC BY-SA 3.0
            // Source - https://stackoverflow.com/q/34826980
            // Posted by Attila Alan, modified by community. See post 'Timeline' for change history
            // Retrieved 2026-09-23, License - CC BY-SA 3.0

            textBox1.Clear();
            textBox1.Text = string.Empty;
            textBox2.Clear();
            textBox2.Text = string.Empty;
            label3.Text = string.Empty;

        }
    }
}
