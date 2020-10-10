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
            conta.Saldo = 100.00;
            conta.Titular.Nome = "Silas Stoffel";
            conta.Numero = "37048-2";
            conta.Agencia = "9260-0";

            Console.WriteLine("Saldo: " + conta.Saldo);
            double valorSaque = 50.00;
            Console.WriteLine("Sacando: R$ " + valorSaque);
            conta.Sacar(valorSaque);
            Console.WriteLine("Saldo Atualizado: R$ " + conta.Saldo);
           
            double valorDeposito = 250.00;
            Console.WriteLine("Depositando: R$ " + valorDeposito);
            conta.Depositar(valorDeposito);
            Console.WriteLine("Saldo Atualizado: R$ " + conta.Saldo);

            valorSaque = 450.00;
            Console.WriteLine("Tentando sacar: R$ " + valorSaque);
            bool sacou = conta.Sacar(valorSaque);
            if (!sacou)
                Console.WriteLine("Saldo insuficiente");

            Console.WriteLine("Saldo Atualizado: R$ " + conta.Saldo);


            // Transferir
            var contaDestino = new ContaCorrente();
            contaDestino.Titular.Nome = "Bruce Wayne (O Batmam)";
            contaDestino.Numero = "0666-6";
            contaDestino.Agencia = "0666";

            // Conta do Silas transfere para o Bruce Wayne
            double valorTransferencia = 120.00; 
            Console.WriteLine("Transferindo R$ " + valorTransferencia + " para " + contaDestino.Titular.Nome);
            Console.WriteLine("Saldo da conta do " + contaDestino.Titular.Nome + " R$ " + contaDestino.Saldo);
            conta.Transferir(valorTransferencia, contaDestino);
            Console.WriteLine("Saldo atualizado da conta do " + contaDestino.Titular.Nome + " R$ " + contaDestino.Saldo);
            Console.WriteLine("Saldo atualizado da conta do " + conta.Titular.Nome + " R$ " + conta.Saldo);


            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para finalizar ...");
            Console.ReadLine();

        }
    }
}
