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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BTNEXEMPLO01_Click(object sender, EventArgs e)
        {
            EXEMPLO01 form1 = new EXEMPLO01();
            form1.Show();
        }

        private void BTNEXERCICIO02_Click(object sender, EventArgs e)
        {
            Exemplo02 exemplo02 = new Exemplo02();
            exemplo02.Show();
        }

        private void BTNEXEMPLO3_Click(object sender, EventArgs e)
        {
            Exemplo03 exemplo03 = new Exemplo03();
            exemplo03.Show();
        }

        private void BTNEXEMPLO4_Click(object sender, EventArgs e)
        {
            Exemplo04 exemplo04 = new Exemplo04();
            exemplo04.Show();
        }

        private void BTNEXEMPLO5_Click(object sender, EventArgs e)
        {
            Exemplo05 exemplo05 = new Exemplo05();
            exemplo05.Show();
        }


    }
}
