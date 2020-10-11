using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Dominio
{
    public class Funcionario
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

        public virtual double GetBonificacao()
        {
            double percentual = 10;
            return this.Salario * (percentual / 100);
        }

        public virtual void AumentarSalario(double percentual = 10)
        {
            this.Salario = this.Salario + (percentual / 100 * this.Salario);
        }
    }
}
