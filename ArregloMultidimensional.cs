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
            Console.WriteLine("Arreglo Miltidimensional");
            Console.WriteLine();

            int[,] matrix;
            matrix = new int[3, 4];

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    matrix[i, j] = i * j;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(matrix[i, j] + "\t");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
    }
}
