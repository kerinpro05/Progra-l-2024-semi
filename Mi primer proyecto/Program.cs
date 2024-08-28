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
            string[] categorias = {
                "superficie",

            };

            String[][] TipoDeConversores = new String[][]{


                new string[] {"Metro cuadrado", "Pie cuadrado", "vara cuadrada", "yarda cuadrada", "tareas", "manzana", "hectaras"} , //Longitud
                

            };

            double[][] valores = {

            new double [] {1, 10.764, 1.431, 1.916, 0.00159033, 69.03,0.0001},//Longitud
           
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Seleccione la unidad a convertir");
                for (int i = 0; i < categorias.Length; i++)
                {
                    Console.WriteLine($"{i}: {categorias[i]}");
                }

                int tipoConversor;

                while (true)
                {
                    Console.Write("\nIngrese el número de la conversion a realizar: ");
                    if (int.TryParse(Console.ReadLine(), out tipoConversor) && tipoConversor >= 0 && tipoConversor < TipoDeConversores.Length)
                    {
                        break;

                    }

                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                    }
                }
                Console.Clear();
                Console.WriteLine($"\nSeleccionaste la categoría: {categorias[tipoConversor]}");
                Console.WriteLine();
                Console.WriteLine("Seleccione la primera unidad:");
                for (int i = 0; i < TipoDeConversores[tipoConversor].Length; i++)
                {
                    Console.WriteLine($"{i}: {TipoDeConversores[tipoConversor][i]}");
                }

                int unidadOrigen;
                while (true)
                {
                    Console.Write("\nIngrese el número de la unidad a convertir: ");
                    if (int.TryParse(Console.ReadLine(), out unidadOrigen) && unidadOrigen >= 0 && unidadOrigen < TipoDeConversores[tipoConversor].Length)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                    }
                }

                Console.WriteLine("\nSeleccione la segunda unidad:");
                for (int i = 0; i < TipoDeConversores[tipoConversor].Length; i++)
                {
                    Console.WriteLine($"{i}: {TipoDeConversores[tipoConversor][i]}");
                }

                int unidadDestino;
                while (true)
                {
                    Console.Write("\nIngrese el número de la unidad a convertir: ");
                    if (int.TryParse(Console.ReadLine(), out unidadDestino) && unidadDestino >= 0 && unidadDestino < TipoDeConversores[tipoConversor].Length)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                    }
                }

                double cantidad;
                while (true)
                {
                    Console.Write("\nIngrese la cantidad a convertir: ");
                    if (double.TryParse(Console.ReadLine(), out cantidad) && cantidad >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese una cantidad numérica válida.");
                    }
                }

                double resultado = (valores[tipoConversor][unidadDestino] / valores[tipoConversor][unidadOrigen]) * cantidad;
                Console.WriteLine($"\nResultado: {cantidad} {TipoDeConversores[tipoConversor][unidadOrigen]} equivalen a {Math.Round(resultado, 3)} {TipoDeConversores[tipoConversor][unidadDestino]}");

                Console.WriteLine("\n¿Desea realizar otra conversión? (s/n)");
                string continuar = Console.ReadLine().ToLower();
                if (continuar != "s")
                {
                    Console.WriteLine("\n");
                    break;
                }

            }

        }
    }
}

    
                                                  