using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWFA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new EXEMPLO01());
            //Application.Run(new Exemplo02());
            //Application.Run(new Exemplo03());
            //Application.Run(new Exemplo04());
            Application.Run(new Exemplo05());
        }
    }
}
