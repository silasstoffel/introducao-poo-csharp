using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class ContaCorrente
    {
        public Cliente titular;
        public string agencia;
        public string numero;
        private double saldo;

        public ContaCorrente()
        {
            this.saldo = 0;
            this.titular = new Cliente();
        }

        public ContaCorrente SetSaldo(double valor)
        {
            this.Depositar(valor);
            return this;
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public bool Sacar(double valor)
        {
            if (!this.PossuiSaldo(valor))
            {
                return false;
            }
            this.saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
                this.saldo += valor;
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
            this.saldo -= valor;
        }

        private bool PossuiSaldo(double valor)
        {
            if (valor <= this.saldo)
            {
                return true;
            }
            return false;
        }
    }
}
