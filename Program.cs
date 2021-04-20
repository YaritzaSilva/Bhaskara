﻿using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada1,entrada2,entrada3;
            double A,B,C,delta,x1,x2;

            Console.WriteLine("--BHASKARA--");
            Console.Write("Valor A: ");
            entrada1= Console.ReadLine();
            A= Convert.ToDouble(entrada1);
            Console.Write("Valor B: ");
            entrada2= Console.ReadLine();
            B= Convert.ToDouble(entrada2);
            Console.Write("Valor C: ");
            entrada3= Console.ReadLine();
            C= Convert.ToDouble(entrada3);
            
            delta= B*B - 4*A*C;
            x1= (-B + Math.Sqrt(delta)) / (2*A);
            x2= (-B - Math.Sqrt(delta)) / (2*A);
            
            if (A<=0)
            {
                Console.WriteLine("Não é uma equação de segundo grau.");
            }

            else if(delta < 0)
            {
                Console.WriteLine($"Como delta = {delta}, a equação não possui raízes reais");
            }

            else
            {
                Console.WriteLine("--RESULTADOS--");
                Console.WriteLine($"x1= {x1} e x2= {x2}");
            }


        }
    }
}
