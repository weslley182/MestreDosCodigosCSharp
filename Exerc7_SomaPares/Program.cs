using Exerc7_SomaPares.Servico;
using System;

namespace Exerc7_SomaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7 - Faça uma aplicação ler 4 números inteiros e calcular a soma dos que forem pares.");
            CalculaSomaParServico calc = new CalculaSomaParServico();
            calc.Ler4Numeros();
            calc.RealizarCalculo();
            Console.WriteLine(calc);
        }
    }
}
