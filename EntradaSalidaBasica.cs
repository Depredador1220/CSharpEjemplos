using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrada y Salida Basica");
            GetDatosUsuario();
            Console.ReadLine();
        }

        static void GetDatosUsuario()
        {
            //Obtener nombre y edad
            Console.Write("Escribe tu nombre: ");
            string nombreUsuario = Console.ReadLine();
            Console.Write("Escribe tu edad: ");
            string edadUsuario = Console.ReadLine();

            //Cambio el color de la salida
            ConsoleColor colorAnterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Salida a la consola
            Console.WriteLine("Hola {0} tu tienes {1} años de edad", nombreUsuario, edadUsuario);

            //Restablece al color que tenia primero
            Console.ForegroundColor = colorAnterior;
        }
    }
}
