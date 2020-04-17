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
            StringBasico();
            Console.ReadLine();
        }

        static void StringBasico()
        {
            Console.WriteLine("Funcionalidad de string basico");
            Console.WriteLine();

            string nombre = "Kensho";
            Console.WriteLine("Tu nombre es: {0}", nombre);
            Console.WriteLine("Tu nombre en mayuscula: {0}", nombre.ToUpper());
            Console.WriteLine("Tu nombre en minuscula: {0}", nombre.ToLower());
            Console.WriteLine("Tu nombre contiene la letra K: {0}", nombre.Contains("K"));

            Console.WriteLine();
        }
    }
}
