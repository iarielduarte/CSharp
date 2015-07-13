using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_a_CSharp
{
    class Test
    {
        static void Main(string[] args)
        {
            Perro sam = new Perro();
            sam.color = "Negro";
            sam.edad = 6;
            Console.WriteLine(sam.ficha("sam"));
            sam.ladrar();
            sam.duerme();
            fin();


        }

        static void fin()
        {
            /*Imprimir en pantalla*/
            Console.WriteLine(">> Fin del Programa - Press ENTER<<");

            /*Mantener la consola hasta que se preciona enter*/
            Console.ReadKey();
        }
    }

    class Perro
    {
        public string color;
        public int edad;

        public void ladrar()
        {
            Console.WriteLine("Guauuu guauuu guuuu uuuuuuuu");
        }

        public void duerme()
        {
            Console.WriteLine("ZZZZ ZZZZ zZ");
        }

        public string ficha(string nombre)
        {
            return nombre+" es de color "+this.color+" y tiene "+this.edad+" de edad.";
        }
    }
}
