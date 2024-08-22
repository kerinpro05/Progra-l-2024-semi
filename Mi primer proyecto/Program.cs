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

            int[] serie = new int[] { 5, 9, 4, 6, 3, 2, 7, 11, 15, 17, 21 };
            foreach (int num en serie ) {
                Consola.WriteLine(" El num {0} es {1} ", num, num % 2 == 0 ? " Par " : " Impar ");
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
            Consola.ReadLine();


        }

        

    }
                                                  