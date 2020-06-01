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
            Console.WriteLine("Clases");

            Carro miCarro = new Carro();
            miCarro.nombre = "Bocho";
            miCarro.velActual = 10;

            for(int i = 0; i <= 10; i++)
            {
                miCarro.SubirVelocidad(5);
                miCarro.ImprimirEstado();
            }

            Console.ReadLine();
        }
    }
}
