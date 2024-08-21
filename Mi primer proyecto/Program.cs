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
            //estructuras de control.
            //1. si. ejercicio. pedir al usuario la edad si es mayor de edad que le diga bienvenido.
            Consola.Write(" Edad: ");
            int edad = int.Parse(Console.ReadLine());​​
            cadena continuar = " s ";
            mientras(continuar == " s ")  {
                Consola.Write(" Edad: ");
                int edad = int.Parse(Console.ReadLine());​​

            si(edad >= 18)  {
                    Consola.WriteLine(" Bienvenido al mundo de las reposabilidades. ");
                }
                demás  {
                    Consola.WriteLine(" Eres un adolescente, disfruta de la vida. ");
                    si(edad < 0)  {
                        Consola.WriteLine(" Edad incorrecta. ");
                    }
                    de lo contrario si(edad <= 2 )  {
                        Consola.WriteLine(" Eres un bebe ");
                    }
                    de lo contrario si(edad<  12 )  {
                        Consola.WriteLine(" Eres un niño ");
                    }
                    de lo contrario si(edad<  18 )  {
                        Consola.WriteLine(" Eres un adolescente. ");
                    }
                    de lo contrario si(edad <= 65 )  {
                        Consola.WriteLine(" Bienvenido al mundo de las reposabilidades. ");
                    }
                    de lo contrario si(edad <= 80 )  {
                        Consola.WriteLine(" Eres un adulto mayor ");
                    }
                    demás  {
                        Consola.WriteLine(" Larga vida ");
                    }
                    Consola.Write(" Desea continuar presionando s, sino cualquier tecla. ");
                    continuar = Console.ReadLine();
                }

                //Pausa.
                Consola.ReadLine();





            }
    }
                                               