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
            //2. Cambiar de ejercicio. pedir al usuario la edad si es mayor de edad que le diga bienvenido.
            cadena continuar = " s ";
            mientras(continuar == " s ")  {
                Consola.WriteLine(" *** MENÚ*** ");
                Consola.WriteLine(" \ n \n  *** MENÚ *** ");
                Consola.WriteLine(" 1. Promedio Notas ");
                Consola.WriteLine(" 2. Promedio Serie Numeros ");
                Consola.WriteLine(" 3. Clasificación edad ");
                Consola.WriteLine(" 4.Salir ");​
                Consola.WriteLine(" 4. Tabla Multiplicar ");
                Consola.WriteLine(" 5.Salir ");​
                Consola.Write(" Opcion: ");
                int opcion = int.Parse(Console.ReadLine());​​​
                Consola.Claro(); //limpiar la consola
                cambiar(opcion)  {
                    caso  1 : //si(opcion==1)
                        promedio();
@@ -29,7 + 31,10 @@ void estático Main(string[] args) {
                        caso  3 : //si(opcion==3)
                        clasificacionEdad();
                        romper;
                        caso  4 : //si(opcion==4)
                    caso  4 :
                        tablaMultiplicar();
                        romper;
                        caso  5 : //si(opcion==5)
                        continuar = " n ";
                        romper;
                    predeterminado: //de lo contrario
@@ -38,6 + 43,13 @@ void estático Main(string[] args) {
                        }
                    }
                }
                void estático tablaMultiplicar()  {
                    Consola.Escribir(" Tabla: ");
                    int ntabla = int.Parse(Console.ReadLine());​​​
            para(int  i = 1 ; i <= 10; i++ )  { //i++ => i = i + 1
                        Consola.WriteLine(" {0}x{1} = {2} ", ntabla, i, ntabla * i);
                    }
                }
                void estático promedio()  {
                    Consola.Escribir(" Lab1 : ");​
            doble lab1 = doble.Parse(Console.ReadLine());




                }
    }
                                               