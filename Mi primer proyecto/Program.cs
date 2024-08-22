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

            //ejercicio encontrar la media aritmetica y la desviación típica de una serie de números.

            Consola.Escribir(" Num 1 : ");
            int num1 = int.Parse(Console.ReadLine());​​​

            Consola.Escribir(" Num 2 : ");
            int num2 = int.Parse(Console.ReadLine());

            Consola.WriteLine(" La suma de {0}+{1}={2} ", num1, num2, suma(num1, num2));
            int[] serie = new int[] { 1, 2, 3, 4, 5 };
            Consola.WriteLine(" La media aritmetica es: {0}, y la desviación típica es: {1} ", media(serie), tipica(serie));

            Consola.ReadLine();​
        }
        int estático suma()
        {
            int respuesta = 10 + 5;
            devolver respuesta;
            media doble  estática(int[ ] serie) {
                doble media = 0;
                foreach (int num en serie )  {
                    medios += num;
                }
                retorno medio / serie.Longitud;
            }
            int estático suma(int  a, int  b)  {
                int respuesta = a + b;
                devolver respuesta;
                tipica doble  estática(int[ ] serie) {
                    doble tipica = 0,
                            m = media(serie);
                    foreach (int num en serie )  {
                        típica += Matemáticas.Pow(núm - m, 2);
                    }
                    típica = Matemáticas.Sqrt(tipica / serie.Longitud);
                    devuelve Math . Round(tipica, 2);

                }

        

    }
                                                  