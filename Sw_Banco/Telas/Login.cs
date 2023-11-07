using Sw_Banco.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sw_Banco.Telas;

namespace Sw_Banco
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            funcionarios.Add(administrador);

        }
        
        List<Conta> contas = new List<Conta>();
        List<Funcionario> funcionarios = new List<Funcionario>();

        Funcionario administrador = new Funcionario("1", "admin", "Administrador", "admin@hotmail.com", DateTime.Now, "None", "None", "None", "1");
        
        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idv = " ";
            string passv=" ";
            foreach (var a in funcionarios)
            {
                if(a.Id_fun == id_tx.Text)
                {
                    idv = a.Id_fun;
                    passv = a.Senha;
                }
            }

            if (idv == id_tx.Text && passv == pass_mask.Text)
            {
                this.Hide();
                TelaF loginFC = new TelaF();
                loginFC.ShowDialog();

            }
            else
            {
                MessageBox.Show("Login ou senha incorretos.");
            }
        }
    }
}
