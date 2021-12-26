using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public int x = 0;
        public int y = 0;
        private int wielk=1;
        private Brush blueBrush;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int sieze = ClientSize.Width / 2;
            int[] k_kor = new int[2];
            int[] k_kor2 = new int[2];
            x = ClientSize.Width / 2;
            y = ClientSize.Height / 2;
            k_kor = minsekwsp(wielk, wielk);
            wielk += 1;
            SolidBrush blueBrusch = new SolidBrush(Color.Blue);
            Pen p = new Pen(Color.Black, 1f);
            Pen p2 = new Pen(Color.White, 1f);
            g.FillRectangle(blueBrusch, k_kor[0], k_kor[1], 2, 2);
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

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
