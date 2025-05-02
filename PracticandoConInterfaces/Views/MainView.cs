using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticandoConInterfaces.Domain;

namespace PracticandoConInterfaces.Views
{
    internal class MainView
    {
        public void MostrarMenu()
        {
            Console.WriteLine("\n Bienvenido al sistema de mensajería \n");
            Console.WriteLine(" [!] Selecciones un medio: \n");
            Console.WriteLine(" 1. SMS");
            Console.WriteLine(" 2. Email");
            Console.WriteLine(" 3. WhatsApp");
            Console.Write(" \n [+] Seleccione una opción: ");

            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    LimpiarConsola();
                    new OperacionesViews().EjecutarSMS();
                    break;

                case "2":
                    Console.WriteLine("\n [!] Has seleccionado Email");
                    break;

                case "3":
                    Console.WriteLine("\n [!] Has seleccionado WhatsApp");
                    break;

                default:
                    Console.WriteLine("\n [!] Opción no válida, por favor intente de nuevo.");
                    break;
            }
        }

        public static void LimpiarConsola()
        {
            Thread.Sleep(200);
            Console.Clear();
        }
    }
}