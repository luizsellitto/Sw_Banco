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
            List<Extrato> extratos = new List<Extrato>();
            Conta cliente = new Conta(2, "admin", "Administrador", "admin@hotmail.com", DateTime.Now, "None", "None", "None", "2", 1000, extratos);
            contas.Add(cliente);
            List<Extrato> extrato = new List<Extrato>();
            Conta cliente2 = new Conta(3, "admin", "Administrador", "admin@hotmail.com", DateTime.Now, "None", "None", "None", "2", 1000, extrato);
            contas.Add(cliente2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(contas, funcionarios));
        }
    }
}
