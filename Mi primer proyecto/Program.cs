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

            //determinar si cada número de la serie es primo.

            int[] serie = new int[] { 5, 9, 4, 6, 3, 2, 7, 11, 15, 17, 21 };
            foreach (int num en serie ) {
                entero i = 1,
                    n = 0;
                mientras(i <= num && n <= 2) {
                    si(num % i == 0) {
                        n++; //n=n+1
                    }
                    yo++;  //yo=yo+1
                }
                Consola.WriteLine(" EL numero {0} {1} ", num, n <= 2 ? " es primo " : " NO es primo ");
            }
            //Uso de funciones...
            Consola.WriteLine(" La suma de 10+5={0} ", suma());

            Consola.ReadLine();​
        }
        int estático suma()
        {
            int respuesta = 10 + 5;
            devolver respuesta;


        }

        

    }
                                                  