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

            //determinar si cada número de la serie es para o impar.
            int[] serie = new int[] { 5, 9, 4, 6, 3, 2 };
            foreach (int num en serie ) {
                Consola.WriteLine(" El num {0} es {1} ", num, num % 2 == 0 ? " Par " : " Impar ");
            }
            Consola.ReadLine();


        }

        

    }
                                                  