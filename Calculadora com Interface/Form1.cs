using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_com_Interface
{
    public partial class Form1 : Form
    {

        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public NumberStyles Cultureinfo { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonzero_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "0";
            // ou -- textresultado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "1";
            // ou -- textresultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "9";
        }

        private void buttonponto_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + ".";
        }

        private void buttonigual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                textresultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUBTRAÇÃO")
            {
                textresultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTIPLICAÇÃO")
            {
                textresultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                textresultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void buttonmenos_Click(object sender, EventArgs e)
        {
            if (textresultado.Text != "")
            {
            valor1 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);
            textresultado.Text = "";
            operacao = "SUBTRAÇÃO";
            sinaloperacao.Text = "-";
            }else
            {
                MessageBox.Show("Informe o numero para a soma, por favor!");
            }
        }


        private void buttonvezes_Click(object sender, EventArgs e)
        {
            if (textresultado.Text != "") 
            {
            valor1 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);
            textresultado.Text = "";
            operacao = "MULTIPLICAÇÃO";
            sinaloperacao.Text = "X";
            }else
            {
                MessageBox.Show("Informe o numero para a soma, por favor!");
            }
        }

        private void buttondivisao_Click(object sender, EventArgs e)
        {
            if (textresultado.Text != "")
            {
            valor1 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);
            textresultado.Text = "";
            operacao = "DIVISÃO";
            sinaloperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe o numero para a soma, por favor!");
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textresultado.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textresultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            sinaloperacao.Text = "";
        }

        private void buttonmais_Click(object sender, EventArgs e)
        {
            if(textresultado.Text != "") 
            { 
            valor1 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);
            textresultado.Text = "";
            operacao = "SOMA";
            sinaloperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe o numero para a soma, por favor!");
            }
        }
    }
}
