using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    { public int r1, r2, r3,r4,r5,r6;
        public string imie, miasto, nazwisko;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            dateTimePicker1.Value = DateTime.Today;
        }

        public string rok, miesiac, dzien;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Random nowy1 = new Random();
            r1 = nowy1.Next(10);
            Random nowy2 = new Random();
            r2 = nowy2.Next(10);
            Random nowy3 = new Random();
            r3 = nowy3.Next(10);
            Random nowy4 = new Random();
            r4 = nowy4.Next(10);
          
            Random nowy5 = new Random();
            r5 = nowy4.Next(10);
            Random nowy6 = new Random();
            r6 = nowy6.Next(10);
            string txt = "imię: " + textBox1.Text + "\n" + "nazwisko: " + textBox2.Text + "\n" + "miasto: " + comboBox1.Text + "\n" + "ident: " + dateTimePicker1.Value.Year + dateTimePicker1.Value.Month + dateTimePicker1.Value.Day + r1 + r2 + r3 + r4 + r5 + r6;
            MessageBox.Show("imię: " + textBox1.Text + "\n" + "nazwisko: " + textBox2.Text + "\n" + "miasto: " + comboBox1.Text + "\n" + "ident: " + dateTimePicker1.Value.Year + dateTimePicker1.Value.Month + dateTimePicker1.Value.Day + r1 + r2 + r3 + r4 + r5 + r6
            );
            File.AppendAllText("dane.txt", txt + Environment.NewLine);
            imie = textBox1.Text;
            nazwisko = textBox2.Text;
            miasto = comboBox1.Text;
            
        }
    }
}
