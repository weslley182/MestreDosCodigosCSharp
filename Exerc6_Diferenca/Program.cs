using System;
using Exerc6_Diferenca.Servico;

namespace Exerc6_Diferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Crie uma aplicação, que demonstre a diferença entre REF e OUT.");            

            Console.WriteLine("Variáveis nValorRef e nValorOut serão inicializadas com valor 10");

            int nValorRef = 10;
            int nValorOut;
            CalculoOutRef serv = new CalculoOutRef();

            serv.MetodoUtilizandoRef(ref nValorRef);
            
            serv.MetodoUtilizandoOut(out nValorOut);

            Console.WriteLine($"Método utilizando ref obteve a saída {nValorRef}");
            Console.WriteLine($"Método utilizando out obteve a saída {nValorOut}");
        }
    }
}
