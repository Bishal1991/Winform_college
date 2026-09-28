using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += UpdateTime;
            timer1.Start();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1_Tick_1(sender, e);
        }

        private void UpdateTime(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.UtcNow.ToString("HH:MM:SS");
            lblTime.Text = DateTime.Now.ToString("HH:MM:SS");
        }
    }
}
