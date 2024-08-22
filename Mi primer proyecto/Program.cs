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

            //Uso de funciones...
            Consola.WriteLine(" La suma de 10+5={0} ", suma());

            Consola.Escribir(" Num 1 : ");
            int num1 = int.Parse(Console.ReadLine());​​​

            Consola.Escribir(" Num 2 : ");
            int num2 = int.Parse(Console.ReadLine());

            Consola.WriteLine(" La suma de {0}+{1}={2} ", num1, num2, suma(num1, num2));

            Consola.ReadLine();​
        }
        int estático suma()
        {
            int respuesta = 10 + 5;
            devolver respuesta;
        }
        int estático suma(int a, int b)
        {
            int respuesta = a + b;
            devolver respuesta;


        }

        

    }
                                                  