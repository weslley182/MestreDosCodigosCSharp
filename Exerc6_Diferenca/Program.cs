using System;

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

            // ref só pode ser utilizado com variáveis iniciadas
            static void MetodoUtilizandoRef(ref int paramX)
            {
                paramX += 5;
            }

            // o out não precisa ser iniciado mas deve ser alterado
            static void MetodoUtilizandoOut(out int paramX)
            {                                
                paramX = 5;                
            }

            MetodoUtilizandoRef(ref nValorRef);
            
            MetodoUtilizandoOut(out nValorOut);

            Console.WriteLine($"Método utilizando ref obteve a saída {nValorRef}");
            Console.WriteLine($"Método utilizando out obteve a saída {nValorOut}");
        }
    }
}
