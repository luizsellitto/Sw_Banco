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
    public partial class Menup : Form
    {
        List<Conta> contas = new List<Conta>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        int idv;
        public Menup(List<Conta> nconta, List<Funcionario> nfuncionarios, int id)
        {
            InitializeComponent();
            contas = nconta;
            funcionarios = nfuncionarios;
            idv = id;

            foreach (var a in contas)
            {
                if (a.Id_con == idv)
                {
                    tx_saldo.Text = Convert.ToString((a.Saldo).ToString("F2"));

                }
            }
        }

        private void bt_sair_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(contas, funcionarios);
            login.Show();
        }

        private void bt_pix_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pix pix = new Pix(contas, funcionarios, idv);
            pix.Show();
        }

        private void bt_transferencia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transferencia transfer = new Transferencia(contas, funcionarios, idv);
            transfer.Show();
        }

        private void bt_emprestimo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emprestimo emprestimo = new Emprestimo(contas,funcionarios, idv);
            emprestimo.Show();
        }

        private void bt_extrato_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisualizarExtrato view = new VisualizarExtrato(contas, funcionarios, idv);
            view.Show();
        }
    }
}
