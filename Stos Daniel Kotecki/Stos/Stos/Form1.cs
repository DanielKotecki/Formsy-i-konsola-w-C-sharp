using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stos
{
    public partial class Form1 : Form
    {
        public int liczba_pobrana;
        public int j = 0;
        Stack<int> stos = new Stack<int>();
        List<TextBox> txt = new List<TextBox>();
        public Form1()
        {
           
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            //POP

            if (stos.Count == 0)
            {
                MessageBox.Show("Nie mozna pobrac wartosci.", "Stos pusty");
            }
            else
            {
                txt[10- stos.Count].Text = "";
                txt[10-stos.Count].Visible = false;
                MessageBox.Show((stos.Pop()).ToString(), "Pobrales wartosc:");
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt.Add(textBox1);
            txt.Add(textBox2);
            txt.Add(textBox3);
            txt.Add(textBox4);
            txt.Add(textBox5);
            txt.Add(textBox6);
            txt.Add(textBox7);
            txt.Add(textBox8);
            txt.Add(textBox9);
            txt.Add(textBox10);
            foreach (TextBox i in txt)
            {
                i.Visible = false;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //wpisuje
        }

        private void push_Click(object sender, EventArgs e)
        {
            
            liczba_pobrana = int.Parse(Pobranie_text.Text);
            stos.Push(liczba_pobrana);
            if (textBox10.Text == "")
            {
                textBox10.Text = liczba_pobrana.ToString();
                textBox10.Visible = true;
            }
            else if (textBox9.Text == "")
            {
                textBox9.Text = liczba_pobrana.ToString();
                textBox9.Visible = true;
            }
            else if (textBox8.Text == "")
            {
                textBox8.Text = liczba_pobrana.ToString();
                textBox8.Visible = true;
            }
            else if (textBox7.Text == "")
            {
                textBox7.Text = liczba_pobrana.ToString();
                textBox7.Visible = true;
            }
            else if (textBox6.Text == "")
            {
                textBox6.Text = liczba_pobrana.ToString();
                textBox6.Visible = true;
            }
            else if (textBox5.Text == "")
            {
                textBox5.Text = liczba_pobrana.ToString();
                textBox5.Visible = true;
            }
            else if (textBox4.Text == "")
            {
                textBox4.Text = liczba_pobrana.ToString();
                textBox4.Visible = true;
            }
            else if (textBox3.Text == "")
            {
                textBox3.Text = liczba_pobrana.ToString();
                textBox3.Visible = true;
            }
            else if (textBox2.Text == "")
            {
                textBox2.Text = liczba_pobrana.ToString();
                textBox2.Visible = true;
            }
            else if (textBox1.Text == "")
            {
                textBox1.Text = liczba_pobrana.ToString();
                textBox1.Visible = true;
            }
           

        }

        private void clear_Click(object sender, EventArgs e)
        {
            stos.Clear();
            foreach (TextBox i in txt)
            {
                i.Text = "";
                i.Visible = false;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
