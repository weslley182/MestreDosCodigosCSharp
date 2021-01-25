using System;
using Exerc6_Diferenca.Servico;

namespace Exerc6_Diferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("6 - Crie uma aplicação, que demonstre a diferença entre REF e OUT.");            

            Console.WriteLine("Variáveis nValorRef e nValorOut serão inicializadas com valor 10");

            int valorRef = 10;
            CalculoOutRef serv = new CalculoOutRef();

            serv.MetodoUtilizandoRef(ref valorRef);
            
            serv.MetodoUtilizandoOut(out int valorOut);

            Console.WriteLine($"Método utilizando ref obteve a saída {valorRef}");
            Console.WriteLine($"Método utilizando out obteve a saída {valorOut}");
        }
    }
}
