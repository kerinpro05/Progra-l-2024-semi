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
            //Prioridad de los operadores aritméticos.
            // se pone el sufijo m para la división con decimales .
            respuesta decimal = 5 + 8 - 2 * 5 / 4m + 1; //14.75 valor incorrecto; 11.5 -> Valor correcto              
            Consola.WriteLine(" La respuesta es: {0} ", respuesta);
            // ejercicio de obtener la nota final de la materia de Programacion I .
            Consola.Escribir(" Lab1 : ");​
            doble lab1 = doble.Parse(Console.ReadLine()); //8    

            Consola.Escribir(" Lab2 : ");​
            doble lab2 = doble.Parse(Console.ReadLine());  //9

            Consola.WriteLine(" La división de 5/4 es {0} ", 5 / 4);
            Consola.Escribir(" Parcial 1: ");
            doble parcial1 = doble.Parse(Console.ReadLine());  //7

            // 8*30%= 2,4
            // 9*30%= 2,7
            // 7*40%= 2,8
            //C1 = 7,9

            doble c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Consola.WriteLine(" La nota de C1 es: {0} ", c1);
            //Pausa.
            Consola.ReadLine();
        }
    }
