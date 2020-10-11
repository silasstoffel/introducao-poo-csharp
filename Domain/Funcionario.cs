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
        public string Cpf { get; set; }

        public double Salario { get; set; }


        public Funcionario()
        {
        }

        public virtual double GetBonificacao()
        {
            double percentual = 10;
            return this.Salario * (percentual / 100);
        }
    }
}
