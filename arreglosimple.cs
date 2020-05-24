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
            Console.WriteLine("Arreglo Basico");
            Console.WriteLine();

            int[] enteros = new int[3];
            enteros[0] = 100;
            enteros[1] = 200;
            enteros[2] = 300;

            foreach(int i in enteros)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }
    }
}
