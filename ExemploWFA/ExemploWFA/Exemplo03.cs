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
        }
            
            public void Somar()
            {
                int quantidade1 = Convert.ToInt32(NUPQTD.Value);
                double valor1 = Convert.ToDouble(MTBVALOR.Text);

                int quantidade2 = Convert.ToInt32(NUDQTD2.Value);
                double valor2 = Convert.ToDouble(MTBVALOR2.Text);

                int quantidade3 = Convert.ToInt32(NUDQTD3.Value);
                double valor3 = Convert.ToDouble(MTBVALOR3.Text);

                double total = (quantidade1 * valor1) + (quantidade2 * valor2) + (quantidade3 * valor3);

                MessageBox.Show("Soma: " + total);
            }
    }
}
    

