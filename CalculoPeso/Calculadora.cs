using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoPeso
{ 

    public partial class nome1 : Form
    {
        // Variáveis 
        string nome;
        double peso;
        double altura;
        double imc;

        public nome1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void recebNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void recebPeso_TextChanged(object sender, EventArgs e) 
        {
            peso = Convert.ToDouble(recebPeso.Text);
        }

        private void recebAltura_TextChanged(object sender, EventArgs e)
        {
            altura = Convert.ToDouble(recebAltura.Text);
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            nome = recebNome.Text;
            imc = Math.Round(peso / Math.Pow(altura, 2));
            if (imc < 16.0)
            {
                MessageBox.Show("Olá " + nome + "Seu IMC é: " + imc + " \n MAGREZA GRAU 3");

            }
            else if (imc >= 16.0 && imc <= 16.9)
            {
                MessageBox.Show("Olá " + nome + "Seu IMC é: " + imc + "\n MAGREZA GRAU 2");

            }
            else if (imc >= 17.0 && imc <= 18.4)
            {
                MessageBox.Show("Olá " + nome + "Seu IMC é: " + imc + "\n MAGREZA GRAU 1");

            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                MessageBox.Show("Olá, " + nome + "Seu IMC é: " + imc + "\n ADEQUADO");
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                MessageBox.Show("Olá, " + nome + "Seu IMC é: " + imc + "\n PRÉ OBESO");
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                MessageBox.Show("Olá, " + nome + "Seu IMC é: " + imc + "\n OBESIDADE GRAU 1");
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                MessageBox.Show("Olá, " + nome + "Seu IMC é: " + imc + "\n OBESIDADE GRAU 2");
            }
            else if (imc >= 40.0)
            {
                MessageBox.Show("Olá, " + nome + "Seu IMC é: " + imc + "\n OBESIDADE GRAU 3");
            }
            else
            {
                MessageBox.Show("Referência não encontrada");
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
