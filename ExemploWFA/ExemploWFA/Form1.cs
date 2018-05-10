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
    public partial class EXEMPLO01 : Form
    {
        public EXEMPLO01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá mundo!");
            
        }

        private void BTNConcatenar_Click(object sender, EventArgs e)
        {
            string nomeDoUsuario = TXTNome.Text;
            string sobrenomeDoUsuario = TXTSobrenome.Text;
            MessageBox.Show(nomeDoUsuario + " " + sobrenomeDoUsuario);
        }

        private void BTNMEDIA_Click(object sender, EventArgs e)
        {
            double nota1 = 0, nota2 = 0, nota3 =0, nota4 = 0;
            try
            {
                nota1 = Convert.ToDouble(TXTNOTA01.Text);
            }
            catch
            {
                MessageBox.Show("Nota 01 deve conter apenas número reais");
                TXTNOTA01.Focus();
                return;
            }

            try
            {   
                nota2 = Convert.ToDouble(TXTNOTA02.Text);
            }

            catch
            {
                MessageBox.Show("Nota 02 deve conter apenas número reais");
                TXTNOTA02.Focus();
                return;
            }

            try
            {
                nota3 = Convert.ToDouble(TXTNOTA03.Text);
            }
            catch
            {
                MessageBox.Show("Nota 03 deve conter apenas número reais");
                TXTNOTA03.Focus();
                return;
            }


            try
            {
                nota4 = Convert.ToDouble(TXTNOTA04.Text);
            }

            catch
            {
                MessageBox.Show("Nota 03 deve conter apenas número reais");
                TXTNOTA04.Focus();
                return;
            }
            

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            string textao = string.Format("Nota 1: {0} \r\nNota 2: {1} \r\nNota 3: {2} \r\nNota 4: {3}\r\n\nMédia: {4}", 
                nota1, nota2, nota3, nota4, media);

            TXTResultado.Text = textao; 
            //MessageBox.Show(string.Format("A média é: {0:n}", media));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idade = Convert.ToInt32(TXTIDADE.Text);
                if (idade < 0)
                {
                    MessageBox.Show("idade não pode ser menor que 0");
                    TXTIDADE.Focus();
                    return;
                }

                if (idade > 150)
                {
                    MessageBox.Show("idade não pode ser maior que 150");
                    TXTIDADE.Focus();
                    return;
                }
            }

            catch
            {
                MessageBox.Show("idade deve conter apenas números inteiros");
                TXTIDADE.Focus();
                
            }
        }
    }
}
