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

            armónica doble  estática(cadena[ ] serie) {
                doble armónica = 0;
                foreach (cadena num en serie )  {
                    armónica += (1.0 / double.Parse(num));
                }
                armónica = serie.Longitud / armónica;
                devuelve Math . Round(armónica, 2);

            }

        

    }
                                                  