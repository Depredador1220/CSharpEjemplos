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
            UsandoFechasYTiempo();
            Console.ReadLine();
        }

        static void UsandoFechasYTiempo()
        {
            Console.WriteLine("Fechas y tiempo");
            Console.WriteLine();

            //El constructor toma el año mes y dia
            DateTime dt = new DateTime(2020, 04, 11);

            //Que dia del mes es este
            Console.WriteLine("El dia de {0} es {1}", dt.Date, dt.DayOfWeek);

            //Agrego dos meses al mes actual
            dt = dt.AddMonths(2);
            Console.WriteLine("Horario de verano: {0}", dt.IsDaylightSavingTime());

            //El constructor toma horas, minutos y segundos
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            //Resto 15 minutos del tiempo que marque con timespan
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));

            Console.WriteLine();
        }
    }
}
