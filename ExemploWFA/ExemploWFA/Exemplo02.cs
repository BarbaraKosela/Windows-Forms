using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWFA
{
    public partial class Exemplo02 : Form
    {
        public Exemplo02()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTNCADASTRAR_Click(object sender, EventArgs e)
        {
            int quantidadeHoras = Convert.ToInt32(TXTQUANTIDADEHORAS.Text);
            double valorHora = Convert.ToDouble(TXTVALORHORA.Text);
            string nome = TXTNOME.Text.Trim();
            double salario = quantidadeHoras * valorHora;

            string cidade = TXTCIDADE.Text.Trim();
            string logradouro = TXTLOGRADOURO.Text.Trim();
            string bairro = TXTBAIRRO.Text.Trim();
            string complemento = TXTCOMPLETO.Text.Trim();
            string unidadeFederativa = cbUnidadeFederativa.SelectedItem.ToString();
            string numero = TXTNUMERO.Text.Trim();
            bool eFemea = rbFemea.Checked;
            string dataDeNascimento = dtpDataNascimento.Text;

            if (salario < 1000)
            {
                MessageBox.Show("Professor de LOL");
            }
            else if (salario < 10000)
            {
                MessageBox.Show("Programador de Fortnite");
            }

            else if (salario < 100000)
            {
                MessageBox.Show("Professor de dota 2");
            }
            else if (salario < 500000)
            {
                MessageBox.Show("Professor Júnior de Tíbia");
            }
            else
            {
                MessageBox.Show("Mestre Pleno de Tíbia");
            }



        }
    }
}
