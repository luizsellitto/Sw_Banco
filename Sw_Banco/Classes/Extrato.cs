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
        public double Valor { get; set; }
        public string Destinatario { get; set; }

    }
}
