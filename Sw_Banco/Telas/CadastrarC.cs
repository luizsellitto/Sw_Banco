using Sw_Banco.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sw_Banco.Telas
{
    public partial class CadastrarC : Form
    {
        List<Conta> contas = new List<Conta>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        public CadastrarC(List<Conta> conta, List<Funcionario> funcionario)
        {
            InitializeComponent();
            contas = conta;
            funcionarios = funcionario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaF loginFC = new TelaF(contas, funcionarios);
            loginFC.ShowDialog();
        }

        private void Salvar_bt_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (contas.Count != 0)
                {
                    int id;
                    Conta ucon = contas.Last();
                    int c = ucon.Id_con;
                    Funcionario ufun = funcionarios.Last();
                    int f = ufun.Id_fun;

                    if (f > c)
                    {
                        id = f + 1;
                        string cpf = textBox1.Text;
                        string nome = textBox2.Text;
                        string email = textBox3.Text;
                        DateTime dataNasc = Convert.ToDateTime(textBox4.Text);
                        string telefone = textBox5.Text;
                        string sexo = textBox6.Text;
                        string endereco = textBox7.Text;
                        string senha = textBox8.Text;
                        Conta newcon = new Conta(id, cpf, nome, email, dataNasc, telefone, sexo, endereco, senha);
                        contas.Add(newcon);
                        this.Hide();
                        TelaF loginFC = new TelaF(contas, funcionarios);
                        loginFC.ShowDialog();
                    }
                    else
                    {
                        id = c + 1;
                        string cpf = textBox1.Text;
                        string nome = textBox2.Text;
                        string email = textBox3.Text;
                        DateTime dataNasc = Convert.ToDateTime(textBox4.Text);
                        string telefone = textBox5.Text;
                        string sexo = textBox6.Text;
                        string endereco = textBox7.Text;
                        string senha = textBox8.Text;
                        Conta newcon = new Conta(id, cpf, nome, email, dataNasc, telefone, sexo, endereco, senha);
                        contas.Add(newcon);
                        this.Hide();
                        TelaF loginFC = new TelaF(contas, funcionarios);
                        loginFC.ShowDialog();
                    }
                }
                else
                {
                    int id;
                    Funcionario ufun = funcionarios.Last();
                    int f = ufun.Id_fun;


                    id = f + 1;
                    string cpf = textBox1.Text;
                    string nome = textBox2.Text;
                    string email = textBox3.Text;
                    DateTime dataNasc = Convert.ToDateTime(textBox4.Text);
                    string telefone = textBox5.Text;
                    string sexo = textBox6.Text;
                    string endereco = textBox7.Text;
                    string senha = textBox8.Text;
                    Conta newcon = new Conta(id, cpf, nome, email, dataNasc, telefone, sexo, endereco, senha);
                    contas.Add(newcon);
                    this.Hide();
                    TelaF loginFC = new TelaF(contas, funcionarios);
                    loginFC.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve algum erro");
            }
        }
    }
}
