using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
<<<<<<< HEAD
            list = new BindingList<User>(users);
            dataGridView1.DataSource = list; // or set in Load handler
=======
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503
        }

        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Contact { get; set; }
            public string Gender { get; set; }
            public string Country { get; set; }
        }

<<<<<<< HEAD
        private int NextID = 1;
        private List<User> users = new List<User>();
        private BindingList<User> list;

        private void UserINfo_Load(object sender, EventArgs e)
        {
            lbl_ID.Text = NextID.ToString();

=======
        int NextID = 1;
        private List<User> users = new List<User>();
        private void UserINfo_Load(object
 sender, EventArgs e)
        {

        }

        private void comboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503
            comboCountry.Items.Add("Nepal");
            comboCountry.Items.Add("India");
            comboCountry.Items.Add("China");
            comboCountry.Items.Add("Bhutan");
            comboCountry.Items.Add("Bangladesh");
            comboCountry.Items.Add("Pakistan");
<<<<<<< HEAD

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
=======
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailField_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void FemaleradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OtherRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CountryField_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameField.Text == "") { MessageBox.Show("Please enter name!!"); return; }
            if (EmailField.Text == "") { MessageBox.Show("Please enter email!!"); return; }
            if (ContactField.Text == "") { MessageBox.Show("Please enter contact!!"); return; }

            string gender;
            if (MaleradioButton.Checked) gender = "Male";
            else if (FemaleradioButton.Checked) gender = "Female";
            else if (OtherRadioButton.Checked) gender = "Other";
            else { MessageBox.Show("Please select gender!!"); return; }

            if (comboCountry.SelectedIndex == -1) { MessageBox.Show("Please select country"); return; }

            var user = new User
            {
                Id = NextID++,
                Name = NameField.Text,
                Email = EmailField.Text,
                Contact = ContactField.Text,
                Gender = gender,
                Country = comboCountry.Text
            };

<<<<<<< HEAD
            list.Add(user);
=======
            users.Add(user);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503

            lbl_ID.Text = NextID.ToString();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NameField.Clear();
            EmailField.Clear();
            ContactField.Clear();
            comboCountry.SelectedIndex = -1;

            MaleradioButton.Checked = false;
            FemaleradioButton.Checked = false;
            OtherRadioButton.Checked = false;

            NameField.Focus();
        }

        private void ContactField_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_ID_Click(object sender, EventArgs e)
        {
            lbl_ID.Text = NextID.ToString();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

<<<<<<< HEAD
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
           
        }

        private static List<User> GetUser()
        {
            return new List<User>();
        }
=======
       
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503
    }
}
