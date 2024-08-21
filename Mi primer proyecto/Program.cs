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
            doble c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Consola.WriteLine(" La nota de C1 es: {0} ", c1);

            Consola.Escribir(" Lab1 : ");​
            lab1 = double.Parse(Console.ReadLine());  //8

            Consola.Escribir(" Lab2 : ");​
            lab2 = double.Parse(Console.ReadLine());  //9

            Consola.Escribir(" Parcial 1: ");
            parcial1 = double.Parse(Console.ReadLine());  //7

            doble c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Consola.WriteLine(" La nota de C2 es: {0} ", c2);

            //TAREA: Obtener la nota final por computo y Nota Final de la matera de Programacion I.


            //Pausa.
            Consola.ReadLine();
        }
    }
                