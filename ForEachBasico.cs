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
            CicloForEachBasico();
            Console.ReadLine();
        }

        static void CicloForEachBasico()
        {
            Console.WriteLine("Ciclo ForEach Basico");
            Console.WriteLine();

            string[] tiposAutos = { "Ford", "BMW", "Yugo", "Tesla" };

            foreach(string c in tiposAutos)
            {
                Console.WriteLine(c);
            }

            int[] enteros = { 10, 20, 30, 40 };

            foreach (int i in enteros)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }
    }
}
