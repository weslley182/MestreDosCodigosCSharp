using Exerc7_SomaPares.Servico;
using System;

namespace Exerc7_SomaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaSomaParServico calc = new CalculaSomaParServico();
            calc.Ler4Numeros();
            calc.RealizarCalculo();
            Console.WriteLine(calc);
        }
    }
}
