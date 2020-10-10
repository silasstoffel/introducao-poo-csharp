using ByteBank.Dominio;
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

            var silas = new Funcionario();
            silas.Nome = "Silas Stoffel";
            silas.Cpf = "00011122233";
            silas.Salario = 4000.00;

            Console.ReadLine();
        }
    }
}
