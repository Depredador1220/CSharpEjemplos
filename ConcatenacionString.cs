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
            StringConcatenacion();
            Console.ReadLine();
        }

        static void StringConcatenacion()
        {
            Console.WriteLine("Concatenacion de string");
            Console.WriteLine();

            string s1 = "Bienvenidos a mi ";
            string s2 = "mundo perfecto";
            string s3 = s1 + s2;
            Console.WriteLine(s3);            

            Console.WriteLine();
        }
    }
}
