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
            conta.saldo = 100.00;
            Console.WriteLine("Saldo: " + conta.saldo);
            double valorSaque = 50.00;
            Console.WriteLine("Sacando: R$ " + valorSaque);
            conta.Sacar(valorSaque);
            Console.WriteLine("Saldo Atualizado: R$ " + conta.saldo);
           
            double valorDeposito = 250.00;
            Console.WriteLine("Depositando: R$ " + valorDeposito);
            conta.Depositar(valorDeposito);
            Console.WriteLine("Saldo Atualizado: R$ " + conta.saldo);

            valorSaque = 450.00;
            Console.WriteLine("Tentando sacar: R$ " + valorSaque);
            bool sacou = conta.Sacar(valorSaque);
            if (!sacou)
                Console.WriteLine("Saldo insuficiente");

            Console.WriteLine("Saldo Atualizado: R$ " + conta.saldo);



            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para finalizar ...");
            Console.ReadLine();

        }
    }
}
