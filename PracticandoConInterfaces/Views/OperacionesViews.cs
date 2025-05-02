using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticandoConInterfaces.Domain;

namespace PracticandoConInterfaces.Views
{
    internal class OperacionesViews
    {
        public OperacionesViews()
        { }

        public void EjecutarSMS()
        {
            Console.WriteLine("\n [!] Has seleccionado SMS [!]");
            Console.Write("\n - Ingrese su número de teléfono: ");
            string? remitente = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(remitente))
            {
                Console.WriteLine("\n [X] El número de teléfono del remitente no puede estar vacío.");
                return;
            }

            Console.Write("\n - Ingrese número del destinatario: ");
            string? destinatario = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(destinatario))
            {
                Console.WriteLine("\n [X] El número del destinatario no puede estar vacío.");
                return;
            }

            Console.Write("\n - Escriba su mensaje: ");
            string? mensaje = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(mensaje))
            {
                Console.WriteLine("\n [X] El mensaje no puede estar vacío.");
                return;
            }

            try
            {
                var sms = new ShortMessageService(remitente);
                string resultado = sms.EnviarMensaje(destinatario, mensaje);
                Console.WriteLine($"\n [:D] {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n [:C] Error: {ex.Message}");
            }
        }
    }
}