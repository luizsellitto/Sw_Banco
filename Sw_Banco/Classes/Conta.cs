using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sw_Banco.Classes
{
    public class Conta
    {
        public int Id_con { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public double Saldo { get; set; }
        public string Senha { get; set; }
        public List<Extrato> Extras { get; set; }
        public double LimiteEmp { get; set; }
        public double TotalEmp { get; set; }
        

        public Conta(int id, string cpf, string nome,string email, DateTime dataNasc, string telefone, string sexo, string endereco, string senha, double saldo, List<Extrato> extras, double LE, double TE)
        {
            Id_con = id;
            Cpf = cpf;
            Nome = nome;
            Email = email;
            DataNasc = dataNasc;
            Telefone = telefone;
            Sexo = sexo;
            Endereco = endereco;
            Senha = senha;
            Saldo = saldo;
            Extras = extras;
            LimiteEmp = LE;
            TotalEmp = TE;

        }

        public virtual void Sacar(double valor)
        {
            if ((Saldo - valor) <= 0)
            {
                string text = ("Saldo insulficiente para o saque");
            }
            else
            {
                Saldo = Saldo - valor;
                string text = ($"O valor de R${valor} foi sacado com sucesso");
            }
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

    }
}
