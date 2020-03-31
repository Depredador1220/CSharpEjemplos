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
            Console.WriteLine("Formato de numeros de datos");
            FormatoNumerosDeDatos();
            Console.ReadLine();
        }

        static void FormatoNumerosDeDatos()
        {
            Console.WriteLine("El valor de 31 en varios formatos");
            Console.WriteLine("Formato d9: {0:d9}", 31);
            Console.WriteLine("Formato f3: {0:f3}", 31);
            Console.WriteLine("Formato n: {0:n}", 31);

            //Determina si las letras son mayusculas y minusculas
            Console.WriteLine("Formato E: {0:E}", 31);
            Console.WriteLine("Formato e: {0:e}", 31);
            Console.WriteLine("Formato X: {0:X}", 31);
            Console.WriteLine("Formato x: {0:x}", 31);
        }
    }
}
