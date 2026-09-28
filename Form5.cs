using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void AddLetterButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(letterLbl.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Controls.Add(letterLbl);
        }

        private void letterLbl_TextChanged(object sender, EventArgs e)
        {
            string text = letterLbl.Text;
        }
    }
}

