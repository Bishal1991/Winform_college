using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {
        Bitmap bitmap;
        Graphics cg;

        int cx, cy;
        int Width = 300, Height = 300;

        Font my_font = new Font("Arial", 12);
        Brush my_brush = new SolidBrush(Color.Black);
        
        
        public Form6()
        {
        InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Width, Height);
            cg = Graphics.FromImage(bitmap);
            cg.Clear(Color.Beige);
            cx = Width / 2;
            cy = Height / 2;

            Draw();
        }

        private void Draw()
        {
            cg.Clear(Color.Wheat);
            cg.DrawEllipse(Pens.Black, 0, 0, Width-1, Height-1);

            cg.DrawString("12", my_font, my_brush, new PointF(140, 3));
            cg.DrawString("1", my_font, my_brush, new PointF(218, 22));
            cg.DrawString("2", my_font, my_brush, new PointF(263, 70));
            cg.DrawString("3", my_font, my_brush, new PointF(285, 140));
            cg.DrawString("4", my_font, my_brush, new PointF(263, 212));
            cg.DrawString("5", my_font, my_brush, new PointF(218, 259));
            cg.DrawString("6", my_font, my_brush, new PointF(142, 279));
            cg.DrawString("7", my_font, my_brush, new PointF(70, 259));
            cg.DrawString("8", my_font, my_brush, new PointF(22, 212));
            cg.DrawString("9", my_font, my_brush, new PointF(1, 140));
            cg.DrawString("10", my_font, my_brush, new PointF(22, 70));
            cg.DrawString("11", my_font, my_brush, new PointF(70, 22));

            Pen hr = new Pen(Color.Red, 5f);
            Pen min = new Pen(Color.Blue, 5f);
            Pen sec = new Pen(Color.Black, 5f);

            cg.DrawLine(hr, cx, cy, 180, 100);
            cg.DrawLine(min, cx, cy, 90, 140);
            cg.DrawLine(sec, cx, cy, 270, 180);

            pictureBox1.Image = bitmap;
        }
    }
}
