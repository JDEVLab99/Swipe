using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Swipe
{
    public partial class Form1 : Form
    {
        Swipe word = new Swipe();
        int val;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "q";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "w";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "e";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "r";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "t";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "y";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "u";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "i";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "o";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "p";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "a";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "s";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "d";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "f";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "g";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "h";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "j";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "k";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "l";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text += "z";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += "x";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += "c";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += "v";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += "b";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "n";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text += "m";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            word.apertura_file();

            val = word.ricerca(textBox4.Text);
            if (val == 1)
            {
                textBox3.Text = " ";
                textBox4.Text = word.get_parola();
                textBox5.Text = " ";
            }
            else
                textBox4.Text = "NOT FOUND";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            word.set_parola(textBox1.Text);
            word.apertura_file();
            word.ris();
            textBox3.Text = word.get_risultato1();
            textBox4.Text = word.get_risultato2();
            textBox5.Text = word.get_risultato3();
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

        private void button28_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            word.clear();
        }

       


    }
    
}
