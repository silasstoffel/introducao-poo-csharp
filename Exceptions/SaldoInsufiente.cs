using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Exceptions
{
    class SaldoInsufienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsufienteException() : base() { }

        public SaldoInsufienteException(string message) : base(message) { }

        public SaldoInsufienteException(double saldo, double valorSaque) 
            : this("Tentativa de saque do valor de R$" + valorSaque + " para saldo de R$" + saldo)
        {
            this.Saldo = saldo;
            this.ValorSaque = valorSaque;
        }
    }
}
