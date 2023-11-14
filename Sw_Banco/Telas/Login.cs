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
using System.Diagnostics.Eventing.Reader;

namespace Sw_Banco
{
    public partial class Login : Form
    {
        List<Conta> contas = new List<Conta>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        
        public Login(List<Conta> nconta, List<Funcionario> nfuncionarios)
        {
            InitializeComponent();
            contas = nconta;
            funcionarios = nfuncionarios;

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            int idv = 0;
            string passv= " ";
            foreach (var a in funcionarios)
            {
                if(a.Id_fun == Convert.ToInt32(id_tx.Text))
                {
                    idv = a.Id_fun;
                    passv = a.Senha;
                }
            }

            if (idv == Convert.ToInt32(id_tx.Text) && passv == pass_mask.Text)
            {
                this.Hide();
                TelaF loginFC = new TelaF(contas, funcionarios);
                loginFC.ShowDialog();

            }
            else
            {
                foreach (var a in contas)
                {
                    if (a.Id_con == Convert.ToInt32(id_tx.Text))
                    {
                        idv = a.Id_con;
                        passv = a.Senha;
                    }
                    
                    
                }
                if (idv == Convert.ToInt32(id_tx.Text) && passv == pass_mask.Text)
                    {
                        this.Hide();
                        Menup menu = new Menup();
                        menu.ShowDialog();

                    }
                else
                    {
                        MessageBox.Show("Login ou senha incorretos.");
                    }
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login login = new Login(contas, funcionarios);
            login.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pass_mask_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
