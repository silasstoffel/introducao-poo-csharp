using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public string Agencia { get; set; }
        public string Numero { get; set; }

        private double _saldo;
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

        public ContaCorrente(string agencia, string numero)
        {
            this._saldo = 0;
            this.Saldo = 0;
            this.Agencia = agencia;
            this.Numero = numero;
            this.Titular = new Cliente();
            ContaCorrente.TotalContas++;
        }

        public bool Sacar(double valor)
        {
            if (!this.PossuiSaldo(valor))
            {
                return false;
            }
            this._saldo -= valor;
            return true;
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
