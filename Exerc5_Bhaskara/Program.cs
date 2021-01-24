﻿using Exerc5_Bhaskara.Servico;
using System;
using System.Globalization;

namespace Exerc5_Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("5 - Crie uma aplicação que calcule a fórmula de Bhaskara.");
            //1,8, -9 result = 1 e -9
            int nValorA;
            int nValorB;
            int nValorC;
            Console.WriteLine("Entre com o valores para cálculo da fórmula de Bhaskara:");            

            do
            {
                Console.WriteLine("Entre com o valor de A:");
            } while (!int.TryParse(Console.ReadLine(), out nValorA));

            do
            {
                Console.WriteLine("Entre com o valor de B:");
            } while (!int.TryParse(Console.ReadLine(), out nValorB));

            do
            {
                Console.WriteLine("Entre com o valor de C:");
            } while (!int.TryParse(Console.ReadLine(), out nValorC));

            CalcularService calc = new CalcularService(nValorA, nValorB, nValorC);            
            calc.CalcularFormula();
            Console.WriteLine($"Valor de R1: {calc.R1.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de R2: {calc.R2.ToString("F2", CultureInfo.InvariantCulture)}");
            
            
            
        }
    }
}
