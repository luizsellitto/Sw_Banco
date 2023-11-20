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
    public partial class Pix : Form
    {
        List<Conta> contas = new List<Conta>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        int idv;
        public Pix(List<Conta> nconta, List<Funcionario> nfuncionarios, int id)
        {
            InitializeComponent();
            contas = nconta;
            funcionarios = nfuncionarios;
            idv = id;
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menup menu = new Menup(contas, funcionarios, idv);
            menu.Show();
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            try
            {

                double saldo;
                bool validar = true;
                foreach (var b in contas)
                {
                    if (b.Id_con == idv)
                    {
                        saldo = b.Saldo;
                        if (Convert.ToDouble(tx_valor.Text) <= 0)
                        {
                            MessageBox.Show("Valor inválido");
                        }
                        else
                        {
                            if (Convert.ToDouble(tx_valor.Text) <= saldo)
                            {
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
                            }
                            else
                            {
                                MessageBox.Show("Valor Inválido - Valor Não Pode Ser Maior Que o Saldo");
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve Algum Erro");
            }
        }
    }
}
