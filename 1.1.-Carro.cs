using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Carro
    {
        public string nombre;
        public int velActual;

        public void ImprimirEstado()
            => Console.WriteLine("{0} va a {1} MPH", nombre, velActual);

        public void SubirVelocidad(int delta)
            => velActual += delta;
    }
}
