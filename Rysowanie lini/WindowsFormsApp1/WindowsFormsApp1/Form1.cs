﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Red, 1);
            g.DrawLine(p, 1, 1, 100, 100);
            MessageBox.Show("klik");
            Pen p1 = new Pen(SystemColors.Control, 1);
            g.DrawLine(p1, 1, 1, 100, 100);
        }
    }
}
