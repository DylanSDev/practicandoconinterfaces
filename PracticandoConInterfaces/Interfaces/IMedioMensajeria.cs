using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticandoConInterfaces.Interfaces
{
    internal interface IMedioMensajeria
    {
        public string EnviarMensaje(string destinatario, string mensaje);

        void RecibirMensaje(string mensaje);
    }
}