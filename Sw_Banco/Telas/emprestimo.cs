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
            foreach (var a in contas)
            {
                if (a.Id_con == idv)
                {
                    double LE = a.LimiteEmp;
                    double TE = a.TotalEmp;
                    tx_limitedeemprestimo.Text = Convert.ToString((LE - TE).ToString($"F2"));

                }
            }
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(tx_valor.Text);
                foreach (var b in contas)
                {
                    if (b.Id_con == idv)
                    {
                        double LE = b.LimiteEmp;
                        double TE = b.TotalEmp;
                        double LT = LE - TE;
                        if (valor <= 0)
                        {
                            MessageBox.Show("O valor de empréstimo não pode ser negativo ou nulo");
                        }
                        else if (valor <= LT)
                        {

                            double juros = (valor * 1.30);
                            this.Hide();
                            EmprestimoRevisao emrevisao = new EmprestimoRevisao(contas, funcionarios, idv, valor, juros);
                            emrevisao.Show();

                        }
                        else
                        {
                            MessageBox.Show("O valor atual ultrapassa o seu Limite de Empréstimo");
                        }


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
            Menup menu = new Menup(contas, funcionarios, idv);
            menu.Show();
        }
    }
}
