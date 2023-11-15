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
    public partial class Emprestimo : Form
    {
        List<Conta> contas = new List<Conta>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        int idv;
        public Emprestimo(List<Conta> nconta, List<Funcionario> nfuncionarios, int id)
        {
            InitializeComponent();
            contas = nconta;
            funcionarios = nfuncionarios;
            idv = id;
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(tx_valor.Text);
            foreach (var b in contas)
            {
                if (b.Id_con == idv)
                {
                            string valorr = $"+ {tx_valor.Text}";
                            double saldof = b.Saldo += valor;
                            Extrato bextra = new Extrato(b.Saldo, saldof, DateTime.Now, valorr, "Empréstimo Adquirido");
                            MessageBox.Show("Emprestimo Realizado com Sucesso");
                            this.Hide();
                            Menup menu = new Menup(contas, funcionarios, idv);
                            menu.Show();
                        
                }
            }
        }
    }
}
