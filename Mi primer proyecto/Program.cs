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

            int[] serie = new int[] { 1, 2, 3, 4, 5 };
            Consola.WriteLine(" La media aritmetica es: {0}, y la desviación típica es: {1} ", media(serie), tipica(serie));
            Consola.Write(" Ingrese la serie de números separados por comas: ");
            Cadena serie = Console.ReadLine();​​
            Cadena[] numeros = serie.Dividir(',');

            Consola.WriteLine(" La media aritmetica es: {0}, y la desviacion tipica es: {1} ", media(numeros), tipica(numeros));

            Consola.ReadLine();​
        }
        media doble  estática(int[] serie)
        {
            media doble  estática(cadena[ ] serie) {
                doble media = 0;
                foreach (int num en serie )  {
                    medios += num;
                    foreach (cadena num en serie )  {
                        media += int.Parse(num);
                    }
                    retorno medio / serie.Longitud;
                }
                tipica doble  estática(int[ ] serie) {
                    estática doble  típica(cadena[ ]  serie)  {
                        doble tipica = 0,
                                m = media(serie);
                        foreach (int num en serie )  {
                            típica += Matemáticas.Pow(núm - m, 2);
                            foreach (cadena num en serie )  {
                                típica += Matemáticas.Pow(int.Parse(núm) - m, 2);​
            }
                            típica = Matemáticas.Sqrt(tipica / serie.Longitud);
                            devuelve Math . Round(tipica, 2);

                        }

        

    }
                                                  