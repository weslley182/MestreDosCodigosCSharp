using Exerc3_Multiplos3.Servico;
using System;

namespace Exerc3_Multiplos3
{
    class Program
    {
        static void Main(string[] args)
        {
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
