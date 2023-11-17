using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sw_Banco.Classes
{
    public class Extrato
    {
        public double Saldo { get; set; }
        public double SaldoFinal { get; set; }
        public DateTime Data { get; set; }
        public string Valor { get; set; }
        public string Tipo { get; set; }
        public string Destinatario { get; set; }
        public string Remetente { get; set; }

        public Extrato(double saldo, double saldoFinal, DateTime data, string valor,string tipo, string destinatario, string remetente)
        {
            Saldo = saldo;
            SaldoFinal = saldoFinal;
            Data = data;
            Valor = valor;
            Tipo = tipo;
            Destinatario = destinatario;
            Remetente = remetente;
        }
    }
}
