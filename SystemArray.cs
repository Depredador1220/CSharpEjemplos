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
            Arreglo();
            Console.ReadLine();
        }

        static void Arreglo()
        {
            Console.WriteLine("Arreglo SystemArray");
            Console.WriteLine();

            string[] bandas = { "Disturbed", "Sonata Artica", "Havenly" };
            Console.WriteLine("Arreglo: ");

            for(int i = 0; i < bandas.Length; i++)
            {
                Console.Write(bandas[i] + ", ");
            }

            Console.WriteLine("\n");

            Array.Reverse(bandas);
            Console.WriteLine("Arreglo en reversa");

            for (int i = 0; i < bandas.Length; i++)
            {
                Console.Write(bandas[i] + ", ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Limpiar algunos");
            Array.Clear(bandas, 1, 2);

            for (int i = 0; i < bandas.Length; i++)
            {
                Console.Write(bandas[i] + ", ");
            }

            Console.WriteLine();
        }
    }
}
