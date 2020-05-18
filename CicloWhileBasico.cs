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
            CicloWhileBasico();
            Console.ReadLine();
        }

        static void CicloWhileBasico()
        {
            Console.WriteLine("Ciclo While Basico");
            Console.WriteLine();

            string salida = "";

            while (salida.ToLower() != "si")
            {
                Console.WriteLine("Dentro del ciclo while");
                Console.Write("Quieres terminar [Si] o [No]: ");
                salida = Console.ReadLine();
            }

            Console.WriteLine();
        }
    }
}
