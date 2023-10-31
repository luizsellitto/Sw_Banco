using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sw_Banco.Classes
{
    internal class Conta
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public double Saldo { get; set; }

        public Conta(int id, string cpf, string nome,string email, DateTime dataNasc, string telefone, string sexo, string endereco, double saldo)
        {
            Id = id;
            Cpf = cpf;
            Nome = nome;
            Email = email;
            DataNasc = dataNasc;
            Telefone = telefone;
            Sexo = sexo;
            Endereco = endereco;
            Saldo = saldo;
        }

        public virtual void Sacar(double valor)
        {
            if ((Saldo - valor) <= 0)
            {
                Console.WriteLine("Saldo insulficiente para o saque");
            }
            else
            {
                Saldo = Saldo - valor;
                Console.WriteLine($"O valor de R${valor} foi sacado com sucesso");
            }
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

    }
}
