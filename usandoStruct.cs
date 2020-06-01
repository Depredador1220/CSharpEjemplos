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
            Console.WriteLine("Usando struct");

            Punto miPunto;
            miPunto.x = 349;
            miPunto.y = 76;
            miPunto.PosicionActual();

            //Modifico los valores
            miPunto.Incremento();
            miPunto.PosicionActual();

            Console.ReadLine();
        }

        struct Punto
        {
            //Campos para la estructura
            public int x;
            public int y;

            public void Incremento()
            {
                x++;
                y++;
            }

            public void Decremento()
            {
                x--;
                y--;
            }

            public void PosicionActual()
            {
                Console.WriteLine("X = {0}, Y = {1}", x, y);
            }
        }
    }
}
