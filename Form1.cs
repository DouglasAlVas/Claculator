using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = ""; 
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = ".";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                textBox1.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "ADIÇÃO")
            {
                textBox1.Text = Convert.ToString(valor1 - valor2);
            }
            if (operacao == "MULTIPLICAÇÃO")
            {
                textBox1.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVISÃO")
            {
                textBox1.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
            {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "SOMA";
                label1.Text = "+";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "ADIÇÃO";
            label1.Text = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "MULTIPLICAÇÃO";
                label1.Text = "*";
            }             
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "DIVISÃO";
                label1.Text = "/";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
              operacao = "";
              textBox1.Text = "";
              label1.Text = "";
              valor1 = 0;
              valor2 = 0;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = "";
            }
        }
    }
}
