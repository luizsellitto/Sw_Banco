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
    public partial class Transferencia : Form
    {
        List<Conta> contas = new List<Conta>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        int idv;
        public Transferencia(List<Conta> nconta, List<Funcionario> nfuncionarios, int id)
        {
            InitializeComponent();
            contas = nconta;
            funcionarios = nfuncionarios;
            idv = id;
        }

        private void bt_Confirmar_Click(object sender, EventArgs e)
        {
            double saldo;
            bool validar = true;
            foreach (var b in contas)
            {
                if (b.Id_con == idv)
                {
                    saldo = b.Saldo;
                    if (saldo > Convert.ToDouble(tx_valor.Text))
                        foreach (var a in contas)
                        {
                            if (a.Id_con == Convert.ToInt32(tx_chave.Text) && idv != Convert.ToInt32(tx_chave.Text))
                            {
                                double valor = Convert.ToDouble(tx_valor.Text);
                                int ido = a.Id_con;
                                validar = false;
                                this.Hide();
                                PixRevisao pixR = new PixRevisao(contas, funcionarios, idv, valor, ido);
                                pixR.Show();
                            }

                        }
                    if (validar)
                    {
                        MessageBox.Show("Chave inválida");
                    }
                    if (saldo < Convert.ToDouble(tx_valor.Text))
                    {
                        MessageBox.Show("Saldo insuficiente");
                    }

                }
            }
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menup menu = new Menup(contas, funcionarios, idv);
            menu.Show();
        }
    }
}
