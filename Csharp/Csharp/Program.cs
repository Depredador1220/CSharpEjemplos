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
            Console.Title = "Mi primera app";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************");
            Console.WriteLine("***** Bienvenido a mi app *****");
            Console.WriteLine("*************************************");
            Console.BackgroundColor = ConsoleColor.Black;
            
            Console.ReadLine();
        }
    }
}
