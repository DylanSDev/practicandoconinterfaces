using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using PracticandoConInterfaces.Exceptions;
using PracticandoConInterfaces.Interfaces;

namespace PracticandoConInterfaces.Domain
{
    internal class ShortMessageService : IMensajeriaCelular
    {
        public string NumeroRemitente { get; }
        public bool EstadoRed { get; private set; }

        public ShortMessageService(string numeroTelefono)
        {
            if (ValidarTelefono(numeroTelefono))
                NumeroRemitente = numeroTelefono;
            else
                throw new NumeroInvalidoException();
        }

        public string EnviarMensaje(string destinatario, string mensaje)
        {
            if (ValidarTelefono(destinatario))
            {
                if (ConsultarEstadoRed())
                    return $"Mensaje enviado a {destinatario} desde {NumeroRemitente}: {mensaje}";
                else
                    throw new SinRedException();
            }
            else
            {
                throw new NumeroInvalidoException();
            }
        }

        public void RecibirMensaje(string mensaje)
        {
        }

        public bool ValidarTelefono(string numeroTelefono)
        {
            //Validamos que el numeroTelefono no sea null o vacío y que contenga solo dígitos
            return !string.IsNullOrWhiteSpace(numeroTelefono) && numeroTelefono.All(char.IsDigit);
        }

        public bool ConsultarEstadoRed()
        {
            int horaActual = DateTime.Now.Hour;
            //Solo se podrán enviar SMS entre las 8 y las 20 horas
            return EstadoRed = horaActual >= 8 && horaActual <= 20;
        }
    }
}