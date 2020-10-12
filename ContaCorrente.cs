using ByteBank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public Cliente Titular { get; set; }

        public int Agencia { get; }

        public int Numero { get; }

        private double _saldo;

        private readonly int _numero;
        private readonly int _agencia;

        public double Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                this.Depositar(value);
            }
        }

        public static int TotalContas { get; private set; }

        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            this._saldo = 0;
            this.Saldo = 0;
            if (numeroAgencia <= 0)
            {
                throw new ArgumentException(
                    "Argumento agência deve ser maior que zero.",
                    nameof(numeroAgencia)
                );
            }
            if (numeroConta <= 0)
            {
                throw new ArgumentException(
                    "Argumento número deve ser maior que zero.",
                    nameof(numeroConta)
                );
            }

            this.Agencia = numeroAgencia;
            this.Numero = numeroConta;
            this.Titular = new Cliente();
            ContaCorrente.TotalContas++;
            ContaCorrente.TaxaOperacao = 30 / ContaCorrente.TotalContas;
        }

        public void Sacar(double valor)
        {
            if (!this.PossuiSaldo(valor))
            {
                throw new SaldoInsufienteException("Saldo Insuficiente");
            }
            this._saldo -= valor;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
                this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.PossuiSaldo(valor))
            {
                this.Debitar(valor);
                contaDestino.Depositar(valor);
            }

            return false;
        }

        private void Debitar(double valor)
        {
            this.Saldo -= valor;
        }

        private bool PossuiSaldo(double valor)
        {
            if (valor <= this.Saldo)
            {
                return true;
            }
            return false;
        }
    }
}
