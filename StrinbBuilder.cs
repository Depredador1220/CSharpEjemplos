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
            EjemploStringBuilder();
            Console.ReadLine();
        }

        static void EjemploStringBuilder()
        {
            Console.WriteLine("String Builder");
            Console.WriteLine();

            StringBuilder sb = new StringBuilder("Videojuegos");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Smash Bros. Ultimate");
            sb.AppendLine("The last of us 2");
            sb.AppendLine("Halo");

            Console.WriteLine(sb.ToString());
            sb.Replace("Halo", "Halo Infinite");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb tiene {0} characteres", sb.Length);

            Console.WriteLine();
        }
    }
}
