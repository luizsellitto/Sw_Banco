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
    public partial class PixRevisao : Form
    {
        List<Conta> contas = new List<Conta>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        int idv;
        double valor;
        int ido;
        public PixRevisao(List<Conta> nconta, List<Funcionario> nfuncionarios, int id, double valore, int idi)
        {
            InitializeComponent();
            contas = nconta;
            funcionarios = nfuncionarios;
            idv = id;
            valor = valore;
            ido = idi;

            foreach (var a in contas)
            {
                if (a.Id_con == ido)
                {
                    tx_valor.Text = Convert.ToString((valor).ToString($"F2"));
                    tx_nome.Text = a.Nome;
                    tx_cpf.Text = a.Cpf;
                    tx_id.Text = Convert.ToString(a.Id_con);

                }
            }
        }

        private void bt_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Pix pix = new Pix(contas, funcionarios, idv);
            pix.Show();
        }

        private void bt_confirmar_Click_1(object sender, EventArgs e)
        {
            foreach (var b in contas)
            {
                if (b.Id_con == idv)
                {

                    foreach (var a in contas)
                    {
                        if (a.Id_con == ido)
                        {
                            string valors = $"- {tx_valor.Text}";
                            string valorr = $"+ {tx_valor.Text}";
                            double saldof = b.Saldo -= valor;
                            Extrato bextra = new Extrato(b.Saldo, saldof, DateTime.Now, valors, $"Pix efetuado para: {a.Nome}");
                            double saldor = a.Saldo += valor;
                            Extrato aextra = new Extrato(a.Saldo, saldor, DateTime.Now, valorr, "Pix Recebido");
                            MessageBox.Show("Pix Realizado");
                            this.Hide();
                            Pix pix = new Pix(contas, funcionarios, idv);
                            pix.Show();
                        }

                    }
                }
            }

        }
    }
}
