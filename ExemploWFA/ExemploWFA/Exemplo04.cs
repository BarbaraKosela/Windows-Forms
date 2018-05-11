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
    public partial class Exemplo04 : Form
    {
        public Exemplo04()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RBSIM.Checked)
            {
                RBSIM.ForeColor = Color.Green;
                RBNAO.ForeColor = Color.Black; 
                GBNOMEJOGO.Visible = true;

            }

            else
            {
                RBSIM.ForeColor = Color.Black;
                RBNAO.ForeColor = Color.Red;
                GBNOMEJOGO.Visible = false;
            }


        }
    }
}
