using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashPlat
{
    public partial class Form1 : Form
    {
        string tipo;
        public string tabelaCheck(float peso)
        {
            string status;

            if (peso>40)
            {
                status="Obesidades mórbida";
                tipo = "Ruim";
            }
            else if (peso>=35 && peso<=40)
            {
                status = "Obesidades grau || ";
                tipo = "Ruim";

            }
            else if (peso >= 30 && peso <= 35)
            {
                status = "Obesidades grau | ";
                tipo = "Ruim";

            }
            else if (peso >= 25 && peso <= 30)
            {
                status = "Sobrepeso";
                tipo = "Ruim";

            }
            else if (peso >= 18.5 && peso <= 25)
            {
                status = "Peso normal";
                tipo = "Bom";

            }
            else if (peso < 18.5 )
            {
                status = "Abaixo do peso";
                tipo = "Ruim";

            }
            else
            {
                status = "indefinido";
                tipo = "Ruim";

            }


            return status;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float imc;
            imc = float.Parse(textBox4.Text)/ (float.Parse(textBox3.Text)* float.Parse(textBox3.Text));
            
            
            //MessageBox.Show($"IMC:  {imc}");
            label13.Text = tabelaCheck(imc);
            textBox1.Text = string.Format("{0:N2}",imc);
            label11.Text = tipo;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
