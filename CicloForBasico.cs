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
            CicloForBasico();
            Console.ReadLine();
        }

        static void CicloForBasico()
        {
            Console.WriteLine("Ciclo For Basico");
            Console.WriteLine();

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("El numero es: {0}", i);
            }

            Console.WriteLine();
        }
    }
}
