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

namespace Sw_Banco.Telas
{
    public partial class TelaF : Form
    {
        List<Conta> contas = new List<Conta>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        public TelaF(List<Conta> conta, List<Funcionario> funcionario)
        {
            InitializeComponent();
            contas = conta;
            funcionarios = funcionario;
        }

        private void Sair_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(contas, funcionarios);
            login.Show();
        }

        private void CF_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarF CF = new CadastrarF(contas, funcionarios);
            CF.Show();
        }

        private void CC_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarC CC = new CadastrarC(contas, funcionarios);
            CC.Show();
        }

        private void TelaF_Load(object sender, EventArgs e)
        {

        }
    }
}
