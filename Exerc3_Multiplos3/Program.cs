using Exerc3_Multiplos3.Servico;
using System;

namespace Exerc3_Multiplos3
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplosService mult = new MultiplosService(3);
            mult.MostrarMultiplosAteh100();
        }
    }
}
