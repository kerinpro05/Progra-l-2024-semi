using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mi_primer_proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prioridad de los operadores aritméticos.
            //ejercicio obtener el promedio de una serie de numeros
            int[] serie = new int[] { 5, 4, 6, 8, 9 };  //32
            int suma = 0;
            foreach (int num en serie ) {
                suma += num;
                //estructuras de control.
                //1. si. ejercicio. pedir al usuario la edad si es mayor de edad que le diga bienvenido.
                Consola.Write(" Edad: ");
                int edad = int.Parse(Console.ReadLine());​​

            si(edad >= 18)  {
                    Consola.WriteLine(" Bienvenido al mundo de las reposabilidades. ");
                }
                demás  {
                    Consola.WriteLine(" Eres un adolescente, disfruta de la vida. ");
                }
                prom  decimal = suma / serie.Longitud;
                Consola.WriteLine(" La suma es: {0}, el promedio {1} ", suma, prom);

                //Pausa.
                Consola.ReadLine();
            }
    }
                            