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
            ParseDesdeStringConTryParse();
            Console.ReadLine();
        }

        static void ParseDesdeStringConTryParse()
        {
            Console.WriteLine("TryParse");
            Console.WriteLine();

            if(bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Valor de b: {0}", b);
            }

            string valor = "Hola";

            if(double.TryParse(valor, out double d))
            {
                Console.WriteLine("Valor de d: {0}", d);
            }

            else
            {
                Console.WriteLine("Fallo al convertir el valor de {0} a double", valor);
            }

            Console.WriteLine();
        }
    }
}
