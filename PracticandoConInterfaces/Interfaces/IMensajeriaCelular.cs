using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticandoConInterfaces.Interfaces
{
    internal interface IMensajeriaCelular : IMedioMensajeria
    {
        public string NumeroRemitente { get; }

        public bool EstadoRed { get; }

        public bool ValidarTelefono(string numeroTelefono);
    }
}