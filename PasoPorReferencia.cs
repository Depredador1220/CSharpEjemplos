using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Persona
    {
        public string nombrePersona;
        public int edadPersona;

        //constructor
        public Persona(string nombre, int edad)
        {
            nombrePersona = nombre;
            edadPersona = edad;
        }

        public Persona() { }

        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0}, Edad: {1}", nombrePersona, edadPersona);
        }

        static void EnviarPersonaPorReferencia(ref Persona p)
        {
            p.edadPersona = 23;
            p = new Persona("Nicole", 23);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Pase por referencia");

            Persona isis = new Persona("Isis", 25);
            Console.WriteLine("\nAntes de llamar por valor, la persona es: ");
            isis.Mostrar();

            EnviarPersonaPorReferencia(ref isis);
            Console.WriteLine("\nDespues de llamar por valor, la persona es: ");
            isis.Mostrar();

            Console.ReadLine();
        }
    }
}
