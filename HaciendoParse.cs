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
            ParseDesdeString();
            Console.ReadLine();
        }

        static void ParseDesdeString()
        {
            Console.WriteLine("Tipos de datos Parse");

            bool b = bool.Parse("True");
            Console.WriteLine("Valor de b es {0}", b);

            double d = double.Parse("99.88");
            Console.WriteLine("Valor de d es {0}", d);

            int i = int.Parse("31");
            Console.WriteLine("Valor de i es {0}", i);

            char c = char.Parse("w");
            Console.WriteLine("Valor de b es {0}", c);

            Console.WriteLine();
        }
    }
}
