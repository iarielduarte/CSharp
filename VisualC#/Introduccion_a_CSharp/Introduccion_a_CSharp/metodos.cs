using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_a_CSharp
{
    class Metodos
    {
        void principal()
        {
            miMetodo("Ariel");
            miMetodo();
            fin();
        }

        static void miMetodo(string nombre)
        {
            Console.WriteLine("Hola "+nombre);
        }

        static void miMetodo()
        {
            Console.WriteLine("Chau !!!");
        }

        static void fin()
        {
            /*Imprimir en pantalla*/
            Console.WriteLine(">> Fin del Programa - Press ENTER<<");

            /*Mantener la consola hasta que se preciona enter*/
            Console.ReadKey();
        }
    
    }
}
