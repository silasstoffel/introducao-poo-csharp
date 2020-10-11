using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Dominio
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }


        public Funcionario(double salario, string cpf)
        {
            Funcionario.TotalDeFuncionarios++;
            this.Cpf = cpf;
            this.Salario = salario;
        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
    }
}
