using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.SetSaldo(100.00);
            conta.titular.SetNome("Silas Stoffel");
            conta.numero = "37048-2";
            conta.agencia = "9260-0";

            Console.WriteLine("Saldo: " + conta.GetSaldo());
            double valorSaque = 50.00;
            Console.WriteLine("Sacando: R$ " + valorSaque);
            conta.Sacar(valorSaque);
            Console.WriteLine("Saldo Atualizado: R$ " + conta.GetSaldo());
           
            double valorDeposito = 250.00;
            Console.WriteLine("Depositando: R$ " + valorDeposito);
            conta.Depositar(valorDeposito);
            Console.WriteLine("Saldo Atualizado: R$ " + conta.GetSaldo());

            valorSaque = 450.00;
            Console.WriteLine("Tentando sacar: R$ " + valorSaque);
            bool sacou = conta.Sacar(valorSaque);
            if (!sacou)
                Console.WriteLine("Saldo insuficiente");

            Console.WriteLine("Saldo Atualizado: R$ " + conta.GetSaldo());


            // Transferir
            var contaDestino = new ContaCorrente();
            contaDestino.titular.SetNome("Bruce Wayne (O Batmam)");
            contaDestino.numero = "0666-6";
            contaDestino.agencia = "0666";

            // Conta do Silas transfere para o Bruce Wayne
            double valorTransferencia = 120.00; 
            Console.WriteLine("Transferindo R$ " + valorTransferencia + " para " + contaDestino.titular.GetNome());
            Console.WriteLine("Saldo da conta do " + contaDestino.titular.GetNome() + " R$ " + contaDestino.GetSaldo());
            conta.Transferir(valorTransferencia, contaDestino);
            Console.WriteLine("Saldo atualizado da conta do " + contaDestino.titular.GetNome() + " R$ " + contaDestino.GetSaldo());
            Console.WriteLine("Saldo atualizado da conta do " + conta.titular.GetNome() + " R$ " + conta.GetSaldo());


            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para finalizar ...");
            Console.ReadLine();

        }
    }
}
