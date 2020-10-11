using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Dominio
{
    public class Diretor : Funcionario
    {

        public Diretor(double salario, string cpf) : base(salario, cpf)
        {
        }

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

        public override void AumentarSalario(double percentual = 15)
        {
            this.Salario = this.Salario + (percentual / 100 * this.Salario);
        }
    }
}
