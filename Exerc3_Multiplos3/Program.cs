using Exerc3_Multiplos3.Servico;
using System;

namespace Exerc3_Multiplos3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 - Faça uma aplicação que imprima todos os múltiplos de 3, entre 1 e 100. Utilize a repetição while.");
            int nCont;
            MultiplosService mult = new MultiplosService(3);
            mult.BuscarMultiplosAteh(100);
            foreach(int numero in mult.Lista)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
