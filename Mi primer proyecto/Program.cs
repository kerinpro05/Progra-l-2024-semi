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
            // 1. si. ejercicio. pedir al usuario la edad si es mayor de edad que le diga bienvenido.
            // 2. Cambiar de ejercicio. pedir al usuario la edad si es mayor de edad que le diga bienvenido.
            cadena continuar = " s ";
            mientras(continuar == " s ")  {
                Consola.Write(" Edad: ");
                int edad = int.Parse(Console.ReadLine());​​

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
                    Consola.WriteLine(" *** MENÚ*** ");
                    Consola.WriteLine(" 1. Promedio Notas ");
                    Consola.WriteLine(" 2. Promedio Serie Numeros ");
                    Consola.WriteLine(" 3. Clasificación edad ");
                    Consola.WriteLine(" 4.Salir ");​
                Consola.Write(" Opcion: ");
                    int opcion = int.Parse(Console.ReadLine());​​​
                cambiar(opcion)  {
                        caso  1 : //si(opcion==1)
                        promedio();
                        romper;
                        caso  2 :  //si(opcion==2)
                        promedioSerie();
                        romper;
                        caso  3 : //si(opcion==3)
                        clasificacionEdad();
                        romper;
                        caso  4 : //si(opcion==4)
                        continuar = " n ";
                        romper;
                    predeterminado: //de lo contrario
                        Console.WriteLine(" opción incorrecta \n \n ");
                        romper;
                    }
                    Consola.Write(" Desea continuar presionando s, sino cualquier tecla. ");
                    continuar = Console.ReadLine();
                }
            }
            void estático promedio()  {
                Consola.Escribir(" Lab1 : ");​
            doble lab1 = doble.Parse(Console.ReadLine());

                Consola.Escribir(" Lab2 : ");​
            doble lab2 = doble.Parse(Console.ReadLine());

                Consola.Escribir(" Parcial 1: ");
                doble parcial1 = doble.Parse(Console.ReadLine());

                doble c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
                Consola.WriteLine(" La nota de C1 es: {0} ", c1);

                Consola.Escribir(" Lab1 : ");​
            lab1 = double.Parse(Console.ReadLine());  //8

                Consola.Escribir(" Lab2 : ");​
            lab2 = double.Parse(Console.ReadLine());  //9

                Consola.Escribir(" Parcial 1: ");
                parcial1 = double.Parse(Console.ReadLine());  //7

                doble c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
                Consola.WriteLine(" La nota de C2 es: {0} ", c2);
            }
            void estático promedioSerie()  {
                int[] serie = new int[] { 5, 4, 6, 8, 9 };  //32
                int suma = 0;
                foreach (int num en serie )  {
                    suma += num;
                }
                prom  decimal = suma / serie.Longitud;
                Consola.WriteLine(" La suma es: {0}, el promedio {1} ", suma, prom);
            }
            static void clasificacionEdad()
            {
                Consola.Write(" Edad: ");
                int edad = int.Parse(Console.ReadLine());​​

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
    }
                                               