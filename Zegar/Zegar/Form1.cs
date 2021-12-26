using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zegar

{
    public partial class Form1 : Form
    {
        Timer t = new Timer();

        int WIDTH = 300, HEIGHT = 300, sek = 140, min = 110, godz = 80;
        
        int x, y;

        Bitmap bmp;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);
            
            x = WIDTH / 2;
            y = HEIGHT / 2;
            
            this.BackColor =Color.White;

            t.Interval = 1000;      
            t.Tick += new EventHandler(this.zeg);
            t.Start();
        }

        private void zeg(object sender, EventArgs e)
        {
           
            g = Graphics.FromImage(bmp);

            int sekundy = DateTime.Now.Second;
            int minuty = DateTime.Now.Minute;
            int godziny = DateTime.Now.Hour;

            int[] handCoord = new int[2];

            
            g.Clear(Color.White);

   
            g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, WIDTH, HEIGHT);
            
            g.DrawString("XII", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
            g.DrawString("III", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
            g.DrawString("VI", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
            g.DrawString("IX", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));
            handCoord = minsekwsp(sekundy, sek);
            g.DrawLine(new Pen(Color.Red, 1f), new Point(x, y), new Point(handCoord[0], handCoord[1]));
            handCoord = minsekwsp(minuty, min);
            g.DrawLine(new Pen(Color.Black, 2f), new Point(x, y), new Point(handCoord[0], handCoord[1]));
            handCoord = gowsp(godziny % 12, minuty, godz);
            g.DrawLine(new Pen(Color.Black, 3f), new Point(x, y), new Point(handCoord[0], handCoord[1]));

           
            pictureBox1.Image = bmp;
           
            this.Text =  "Zegar" + godziny + ":" + minuty + ":" + sekundy;

            
            g.Dispose();
        }

        
        private int[] minsekwsp(int war, int hlen)
        {
            int[] Wsp = new int[2];
            war *= 6;

            if (war >= 0 && war <= 180)
            {
                Wsp[0] = x + (int)(hlen * Math.Sin(Math.PI * war / 180));
                Wsp[1] = y - (int)(hlen * Math.Cos(Math.PI * war / 180));
            }
            else
            {
                Wsp[0] = x - (int)(hlen * -Math.Sin(Math.PI * war / 180));
                Wsp[1] = y - (int)(hlen * Math.Cos(Math.PI * war / 180));
            }
            return Wsp;
        }

       
        private int[] gowsp(int gval, int mval, int hlen)
        {
            int[] wsp = new int[2];
            int val = (int)((gval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                wsp[0] = x + (int)(hlen * Math.Sin(Math.PI * val / 180));
                wsp[1] = y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                wsp[0] = x - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                wsp[1] = y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return wsp;
        }
    }
}