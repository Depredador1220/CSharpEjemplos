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
            Console.WriteLine("Formato de numero con string usando PresentationFramework");
            MostrarMensaje();
            Console.ReadLine();
        }

        static void MostrarMensaje()
        {
            //Usando string.format() para una literal de string
            string mensajeUsuario = string.Format("31 en hexadecimal es: {0:x}", 31);

            //Se necesita hacer referencia al PresentationFramework.dll
            //para poder compilar esta linea de codigo
            System.Windows.MessageBox.Show(mensajeUsuario);
        }
    }
}
