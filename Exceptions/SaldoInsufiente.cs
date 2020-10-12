using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Exceptions
{
    class SaldoInsufienteException : Exception
    {

        public SaldoInsufienteException() : base() { }

        public SaldoInsufienteException(string message) : base(message) { }
    }
}
