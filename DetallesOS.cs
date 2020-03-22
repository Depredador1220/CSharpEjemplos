using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static int Main(string[] args)
        {
            MostrarDetallesEntorno();

            Console.ReadLine();
            return -1;
        }

        static void MostrarDetallesEntorno()
        {
            foreach(string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);

                Console.WriteLine("OS: {0}", Environment.OSVersion);
                Console.WriteLine("Numero de procesadores: {0}", Environment.ProcessorCount);
                Console.WriteLine("Version .NET: {0}", Environment.Version);
            }
        }
    }
}
