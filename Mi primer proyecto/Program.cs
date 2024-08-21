using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi_primer_proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Booleano comprobar = verdadero;
            Consola.WriteLine(" El valor es: {0} ", comprobar);
            //Prioridad de los operadores aritméticos.
            //se pone el sufijo m para la división con decimales.
            respuesta  decimal = 5 + 8 - 2 * 5 / 4m + 1;  //14.75 valor incorrecto; 11.5 -> Valor correcto
            Consola.WriteLine(" La respuesta es: {0} ", respuesta);

            Consola.Escribir(" Nombre: ");
            cadena nombre = Console.ReadLine();​​

            Consola.WriteLine(" Hola {0} bienvenido ", nombre);

            FechaHora fechaActual = new DateTime();
            fechaActual = DateTime.Now;
            Consola.WriteLine(" La fecha actual es: {0} ", fechaActual);
            Consola.WriteLine(" La división de 5/4 es {0} ", 5 / 4);
            //Pausa.
            Consola.ReadLine();

        }
    }
