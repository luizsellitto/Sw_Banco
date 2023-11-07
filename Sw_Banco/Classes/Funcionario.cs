using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sw_Banco.Classes
{
    internal class Funcionario
    {
        public string Id_fun { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public string Senha { get; set; }

        public Funcionario(string id, string cpf, string nome, string email, DateTime dataNasc, string telefone, string sexo, string endereco, string senha)
        {
            Id_fun = id;
            Cpf = cpf;
            Nome = nome;
            Email = email;
            DataNasc = dataNasc;
            Telefone = telefone;
            Sexo = sexo;
            Endereco = endereco;
            Senha = senha;
        }

    }
}
