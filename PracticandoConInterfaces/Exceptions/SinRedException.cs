using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticandoConInterfaces.Exceptions
{
    internal class SinRedException : Exception
    {
        public SinRedException() : base("No se puede enviar el mensaje, la red está fuera de servicio.")
        {
        }

        public SinRedException(string message) : base(message)
        {
        }

        public SinRedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}