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
            Console.WriteLine("Arreglo De Objetos");
            Console.WriteLine();

            object[] misObjetos = new object[4];
            misObjetos[0] = 10;
            misObjetos[1] = false;
            misObjetos[2] = new DateTime(2020, 05, 12);
            misObjetos[3] = "Blender";

            foreach(object obj in misObjetos)
            {
                Console.WriteLine("Tipo: {0}, Valor: {1}", obj.GetType(), obj);
            }

            Console.WriteLine();
        }
    }
}
