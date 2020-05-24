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
            Console.WriteLine("Arreglo Implicito");
            Console.WriteLine();

            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a tiene: {0}", a.ToString());

            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b tiene: {0}", b.ToString());

            var c = new[] { "Hola", null, " Mundo" };
            Console.WriteLine("c tiene: {0}", c.ToString());

            Console.WriteLine();
        }
    }
}
