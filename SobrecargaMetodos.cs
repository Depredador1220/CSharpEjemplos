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
            Console.WriteLine("Sobrecarga de metodos");

            Console.WriteLine(Suma(10, 10));
            Console.WriteLine(Suma(900_000_000_000, 900_000_000_000));
            Console.WriteLine(Suma(4.3, 4.4));

            Console.ReadLine();
        }

        static int Suma(int x, int y)
        {
            return x + y;
        }

        static double Suma(double x, double y)
        {
            return x + y;
        }

        static long Suma(long x, long y)
        {
            return x + y;
        }
    }
}
