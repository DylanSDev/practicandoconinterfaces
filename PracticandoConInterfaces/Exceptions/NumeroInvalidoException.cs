using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticandoConInterfaces.Exceptions
{
    internal class NumeroInvalidoException : Exception
    {
        public NumeroInvalidoException() : base("El numero ingresado no es válido. ")
        {
        }

        public NumeroInvalidoException(string mensaje) : base(mensaje)
        {
        }

        public NumeroInvalidoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
        }
    }
}