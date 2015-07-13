using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Introduccion_a_CSharp
{
    class Variables
    {
        void var()
        {
            /*Contantes*/
            const int dni = 3999371;
            /* Variables*/
            byte edad = 36; //0 to 255
            double altura = 1.80;
            short calzado = 43;
            bool esjava = true;
            string nombre = "Ariel";
            dynamic apellido = "Duarte";
            /*Imprimir en pantalla*/
            Console.WriteLine("Mi nombre es :" + nombre + "Apellido :"+apellido);
            Console.WriteLine("Mi edad es :" + edad);

            /*Mantener la consola hasta que se preciona enter*/
            Console.ReadKey();
        }
    }

    class Operadores
    {
        void oper(string[] args)
        {
            int var1 = 35;
            int var2 = 45;

            /*Incremento y decremento*/
            int contador = 1;
            int decremento = 100;
            contador++;
            decremento--;
            contador += 2;
            decremento -= 3;
            Console.WriteLine("El valor del contador es :" + contador);
            Console.WriteLine("El valor del decremento es :" + decremento);
            /*Comparaciones*/
            Console.WriteLine("Son iguales :" + (var1 == var2));
            Console.WriteLine("Son diferentes :" + (var1 != var2));
            Console.WriteLine(var1 + " es menor que o igual que " + var2 + " : "+(var1 <= var2));
            /*Operadores logicos*/
            Console.WriteLine(("Operador AND "+(var1 <= var2 && contador != decremento)));
            Console.WriteLine(("Operador OR " + (var1 <= var2 || contador != decremento)));
            /*Imprimir en pantalla*/
            Console.WriteLine("Suma :" + var1 + var2);

            /*Mantener la consola hasta que se preciona enter*/
            Console.ReadKey();

        }

    }

    class Estructuras
    {
         void control()
        {
            Console.WriteLine(">> Para Entrar presione '1'=SI y '0'=NO - Press (1/0?) >>");
            /*Lectura de teclado y convertimos en numerico*/
            int entrar = Convert.ToByte(Console.ReadLine());
             /*Estructura IF..*/
            if (entrar == 1)
            {
                 Console.WriteLine("Estas adentro!");
            }
            else if (entrar == 0)
            {
                 Console.WriteLine("Fueraaaaaaaaa!");
            }
            else
            {
                Console.WriteLine("Precionaste cualquier macho!");
            }

            /*Estructura SWITCH..*/
            Console.WriteLine(">> Ingrese el numero del dia de la semana >>");
            int dia = Convert.ToByte(Console.ReadLine());
                       
             switch(dia){
                 case 1:
                     Console.WriteLine("Es Lunes");
                     break;
                 case 2:
                     Console.WriteLine("Es Martes");
                     break;
                 case 3:
                     Console.WriteLine("Es Miercoles");
                     break;
                 case 4:
                     Console.WriteLine("Es Jueves");
                     break;
                 case 5:
                     Console.WriteLine("Es Viernes");
                     break;
                 case 6:
                     Console.WriteLine("Es Sabado");
                     break;
                 case 7:
                     Console.WriteLine("Es Domingo");
                     break;
                 default:
                     Console.WriteLine("No menso!!");
                     break;

             }

             /*Imprimir en pantalla*/
             Console.WriteLine(">> Fin del Prograna - Press ENTER<<");

             /*Mantener la consola hasta que se preciona enter*/
             Console.ReadKey();
        }

         void ciclicas()
         {
             /*Estructura FOR..*/
             for (int c = 1; c < 10; c++)
             {
                 Console.WriteLine("el contador FOR esta en " + c);
             }

             /*Estrucutura WHILE...*/
             int contador = 1;
             while (contador < 20)
             {
                 Console.WriteLine("el contador WHILE esta en " + contador);
                 contador++;
             }

             /*Estrucutura DO..WHILE..*/
             int contador2 = 1;
             do
             {
                 Console.WriteLine("el contador DO WHILE esta en " + contador2);
                 //contador2++;
             } while (contador2 >= 10);
             
             /*Imprimir en pantalla*/
             Console.WriteLine(">> Fin del Prograna - Press ENTER<<");

             /*Mantener la consola hasta que se preciona enter*/
             Console.ReadKey();
         }


    }

    class Arrays{
        void vector()
        {
            string[] nombre = new string[10];
            nombre[0] = "Joel";
            nombre[1] = "Victor";
            nombre[2] = "Martin";
            nombre[3] = "Toto";
            nombre[4] = "Follo";
            nombre[5] = "Javier";

            foreach (string i in nombre)
            {
                Console.WriteLine(i);
            }

            /*Imprimir en pantalla*/
            Console.WriteLine(">> Fin del Prograna - Press ENTER<<");

            /*Mantener la consola hasta que se preciona enter*/
            Console.ReadKey();
        }
    }

    class EntradaSalida
    {
        void LecturaEscrituraArchvios()
        {
            /*Lectura y escritura de archivos*/
            StreamWriter texto = File.AppendText("prueba.txt");//Para no borrar el contenido anterior del archivo
            texto.WriteLine("C# es un lenguaje para tontos!");
            texto.Close();

            TextReader leerTexto = new StreamReader("prueba.txt");
            Console.WriteLine(leerTexto.ReadLine());
            
            /*Imprimir en pantalla*/
            Console.WriteLine(">> Fin del Prograna - Press ENTER<<");

            /*Mantener la consola hasta que se preciona enter*/
            Console.ReadKey();
        }

        void agenda()
        {
            Console.WriteLine("Ingrese el nombre >");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el telefono >");
            string telefono = Console.ReadLine();

            StreamWriter agenda = File.AppendText("agenda.csv");
            agenda.WriteLine(nombre+","+telefono);
            agenda.Close();
            Console.WriteLine("Registro guardado con exito!");

            /*Imprimir en pantalla*/
            Console.WriteLine(">> Fin del Prograna - Press ENTER<<");

            /*Mantener la consola hasta que se preciona enter*/
            Console.ReadKey();
        }
    }
    
}
