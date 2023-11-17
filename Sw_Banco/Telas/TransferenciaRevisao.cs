﻿using Sw_Banco.Classes;
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
    public partial class TransferenciaRevisao : Form
    {
        List<Conta> contas = new List<Conta>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        int idv;
        double valor;
        int ido;
        public TransferenciaRevisao(List<Conta> nconta, List<Funcionario> nfuncionarios, int id, double valore, int idi)
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

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transferencia transfer = new Transferencia(contas, funcionarios, idv);
            transfer.Show();
        }

        private void bt_confirmar_Click_1(object sender, EventArgs e)
        {
            try
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
                                double saldof = b.Saldo - valor;
                                Extrato bextra = new Extrato(b.Saldo, saldof, DateTime.Now, valors, "Transferência", a.Nome, " ");
                                b.Saldo -= valor;
                                b.Extras.Add(bextra);

                                double saldor = a.Saldo + valor;
                                Extrato aextra = new Extrato(a.Saldo, saldor, DateTime.Now, valorr, "Transferência", " ", b.Nome);
                                a.Saldo += valor;
                                a.Extras.Add(aextra);
                                MessageBox.Show("Transferência Realizada");
                                goto saida;
                            }

                        }
                    }
                }
            saida:;
                this.Hide();
                Menup menu = new Menup(contas, funcionarios, idv);
                menu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve Algum Erro");
            }
        }

        private void tx_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransferenciaRevisao_Load(object sender, EventArgs e)
        {

        }
    }
}
