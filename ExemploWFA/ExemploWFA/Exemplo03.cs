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
    public partial class Exemplo03 : Form
    {
        int quantidade1 = 0, quantidade2 = 0, quantidade3 = 0;
        double valor1 = 0, valor2 = 0, valor3 = 0, total = 0;



        public Exemplo03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RBSOMAR.Checked)
            {

                Somar();

            }

            else if (RBMEDIA.Checked)
            {
                Media();

            }

            else if (RBMENOR.Checked)
            {
                Menor();
            }


            else if (RBMAIOR.Checked)
            {
                Maior();
            }

            else
            {
                MessageBox.Show("Nenhuma das opções foi selecionada");
            }
        }
        
       

        private void ArmazenarInformacoes()
        {
            quantidade1 = Convert.ToInt32(NUPQTD.Value);
            valor1 = Convert.ToDouble(MTBVALOR.Text);

            quantidade2 = Convert.ToInt32(NUDQTD2.Value);
            valor2 = Convert.ToDouble(MTBVALOR2.Text);

            quantidade3 = Convert.ToInt32(NUDQTD3.Value);
            valor3 = Convert.ToDouble(MTBVALOR3.Text);

            total = (quantidade1 * valor1) + (quantidade2 * valor2) + (quantidade3 * valor3);
        }
            
            public void Somar()
            {

                ArmazenarInformacoes();
                MessageBox.Show("Soma: " + total);
            }

            public void Media()
            {

                ArmazenarInformacoes();
                double media = total / 3;
                MessageBox.Show("Média: " + media);

            }

            public void Menor()
            {
                double menorValor = int.MaxValue;

                if (menorValor < valor1)
                {
                    menorValor = valor1;
                }

                if (menorValor < valor2)
                {
                    menorValor = valor2;
                }

                if (menorValor < valor3)
                {
                    menorValor = valor3;
                }

                MessageBox.Show("Menor valor: " + menorValor);
            }

            public void Maior()
            {
                double maiorValor = int.MinValue;

                if (maiorValor > valor1)
                {
                    maiorValor = valor1;
                }

                if (maiorValor > valor2)
                {
                    maiorValor = valor2;
                }

                if (maiorValor > valor3)
                {
                    maiorValor = valor3;
                }

                MessageBox.Show("Maior valor: " + maiorValor);
            }
    }
}
    

