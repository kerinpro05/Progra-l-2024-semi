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
            Consola.Write(" Sueldo: ");
            doble sueldo = double.Parse(Console.ReadLine()),​​
                afp = sueldo * 6,25 / 100 ,
                isss = sueldo * 3 / 100;
            isss = sueldo * 3 / 100 ,
                esr = 0;
            sueldo -= afp;

            doble isr = 0;
            para(int  i = 0 ; i < 5; i++ )  {
                if (sueldo >= matriz[i, 0] && sueldo <= matriz[i, 1])
                {
                    isr = (sueldo - (matriz[i, 0] - 0.01)) * matriz[i, 2] / 100 + matriz[i, 3];


                }

    }
                                                  