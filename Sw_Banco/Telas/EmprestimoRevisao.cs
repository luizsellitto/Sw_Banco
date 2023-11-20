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
    public partial class EmprestimoRevisao : Form
    {
        List<Conta> contas = new List<Conta>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        int idv;
        double valor;
        double juros;
        public EmprestimoRevisao(List<Conta> nconta, List<Funcionario> nfuncionarios, int id, double valors, double juroS)
        {
            InitializeComponent();
            contas = nconta;
            funcionarios = nfuncionarios;
            idv = id;
            valor = valors;
            juros = juroS;
            foreach (var a in contas)
            {
                if (a.Id_con == idv)
                {
                    tx_valor.Text = Convert.ToString((valor).ToString($"F2"));
                    tx_juros.Text = Convert.ToString((juros).ToString($"F2"));
                    tx_nome.Text = a.Nome;
                    tx_cpf.Text = a.Cpf;
                    tx_id.Text = Convert.ToString(a.Id_con);

                }
            }

            this.juros = juros;
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var b in contas)
                {
                    if (b.Id_con == idv)
                    {
                        b.TotalEmp = b.TotalEmp + valor;
                        string valorr = $"+ {tx_valor.Text}";
                        double saldof = b.Saldo + valor;
                        Extrato bextra = new Extrato(b.Saldo, saldof, DateTime.Now, valorr, "Empréstimo", " ", "InnovaBank");
                        b.Extras.Add(bextra);
                        b.Saldo += valor;
                        MessageBox.Show("Emprestimo Realizado com Sucesso");
                        this.Hide();
                        Menup menu = new Menup(contas, funcionarios, idv);
                        menu.Show();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve Algum Erro");
            }


        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emprestimo emprestimo = new Emprestimo(contas, funcionarios, idv);
            emprestimo.Show();
        }

        private void EmprestimoRevisao_Load(object sender, EventArgs e)
        {

        }

        private void tx_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_juros_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
