﻿using System;
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
            //Uso de matrices.
            int[,] matriz = nuevo  int[,]  {
                { 5 , 4 , 5 , 2 , 1 } ,
                { 1 , 2 , 8 , 9 , 3 }
                //Uso de matrices. Calcula el sueldo de una persona.

                doble[,] matriz = nuevo  doble[,]  {
                    { 0,01 ,    487,6 ,   0 ,  0 } ,
                { 487,61 ,  642,85 ,  10 , 17,48 } ,
                { 642,86 ,  915,81 ,  10 , 32,70 } ,
                { 915,82 ,  2058,67 , 20 , 60,00 } ,
                { 2058,68 , 9999999 , 30 , 288,57 } ,
            };
                para(int  i = 0 ; i < 2; i++ )  {
                    para(int  j = 0 ; j < 5; j++ )  {
                        Consola.Escribir(" {0} ", matriz[i, j]);
                        Consola.Write(" Sueldo: ");
                        doble sueldo = double.Parse(Console.ReadLine()),​​
                afp = sueldo * 6,25 / 100 ,
                isss = sueldo * 3 / 100;
                        sueldo -= afp;

                        doble isr = 0;
                        para(int  i = 0 ; i < 5; i++ )  {
                            if (sueldo >= matriz[i, 0] && sueldo <= matriz[i, 1])
                            {
                                isr = (sueldo - (matriz[i, 0] - 0.01)) * matriz[i, 2] / 100 + matriz[i, 3];
                            }
                            Consola.WriteLine(" \ n ");
                        }
                        //Pausa
                        Consola.ReadKey();​
            sueldo -= isss;
                        sueldo -= isr;
                        Consola.WriteLine(" Sueldo Neto: {0}, AFP: {1}, ISSS: {2}, ISR: {3} ", Math.Round(sueldo, 2), afp, isss, Math.Round(isr, 2));

                        Consola.ReadLine();
                    }
    }
                                                  