namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //string name = textBox1.Text;
            //string pass = textBox2.Text;
            //MessageBox.Show(name + " "+ pass);
            //label3.Text = $" Welcome {name}!, Glad to see you.";
            //label3.Visible = true;

            //Form2 frm = new Form2();
            //frm.Show(this);
            //this.Hide();

            Form3 frm = new Form3();
            frm.Show(this);
            //this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Output(object sender, EventArgs e)
        {

        }
    }
}
