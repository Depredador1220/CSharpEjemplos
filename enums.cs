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
            Console.WriteLine("Manejando Enums");

            tipoEmpleado emp = tipoEmpleado.RRHH;
            Bonos(emp);

            Console.ReadLine();
        }

       //enums como parametros
       static void Bonos(tipoEmpleado e)
        {
            switch(e)
            {
                case tipoEmpleado.RRHH:
                    Console.WriteLine("Recibe bono si contrata a alguien de calidad");
                    break;

                case tipoEmpleado.Obrero:
                    Console.WriteLine("Recibe bono si llega temprano todo el mes");
                    break;

                case tipoEmpleado.Jefe:
                    Console.WriteLine("Recibe bono si cumple con las metas del mes");
                    break;

                case tipoEmpleado.VicePresidente:
                    Console.WriteLine("No recibe bono");
                    break;
            }
        }

        enum tipoEmpleado : byte
        {
            RRHH           = 10,
            Obrero         = 1,
            Jefe           = 100,
            VicePresidente = 9
        }
    }
}
