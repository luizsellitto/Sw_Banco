using Sw_Banco.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sw_Banco
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Conta> contas = new List<Conta>();
            List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario administrador = new Funcionario(1, "admin", "Administrador", "admin@hotmail.com", DateTime.Now, "None", "None", "None", "1");
            funcionarios.Add(administrador);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(contas, funcionarios));
        }
    }
}
