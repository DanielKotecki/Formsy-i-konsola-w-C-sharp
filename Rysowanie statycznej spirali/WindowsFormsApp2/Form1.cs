using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            const int width = 380;
            const int height = 380;
            PointF archimedeanPoint(int degrees)
            {
                const double a = 1;
                const double b = 9;
                double t = degrees * Math.PI / 180;
                double r = a + b * t;
                return new PointF { X = (float)(width / 2 + r * Math.Cos(t)), Y = (float)(height / 2 + r * Math.Sin(t)) };
            }

           
            
                var bm = new Bitmap(width, height);
                var g = Graphics.FromImage(bm);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillRectangle(new SolidBrush(Color.White), new Rectangle { X = 0, Y = 0, Width = width, Height = height });
                var pen = new Pen(Color.OrangeRed, 1.5f);

                var spiral = Enumerable.Range(0, 360 * 3).AsParallel().AsOrdered().Select(archimedeanPoint);
                var p0 = new PointF(width / 2, height / 2);
                foreach (var p1 in spiral)
                {
                    g.DrawLine(pen, p0, p1);
                    p0 = p1;
                }
            pictureBox2.Image = bm;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
        }
    }
}
