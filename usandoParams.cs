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
            double promedio;
            promedio = CalcularPromedio(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("El promedio es: {0}", promedio);

            double[] datos = { 4.0, 3.2, 5.7 };
            promedio = CalcularPromedio(datos);
            Console.WriteLine("El promedio de los datos es: {0}", promedio);

            Console.WriteLine("El promedio de lso datos es: {0}", CalcularPromedio());    
            Console.ReadLine();
        }

        static double CalcularPromedio(params double[] valores)
        {
            Console.WriteLine("Enviame {0} dobles", valores.Length);

            double sum = 0;

            if(valores.Length == 0)
            {
                return sum;
            }

            for(int i = 0; i < valores.Length; i++)
            {
                sum += valores[i];                
            }

            return (sum / valores.Length);
        }
    }
}
