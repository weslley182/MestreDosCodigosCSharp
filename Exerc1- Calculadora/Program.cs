using System;
using Exerc1_Calculadora.Servicos;

namespace Exerc1_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crie uma aplicação, que receba os valores A e B. Mostre de forma simples, como utilizar variáveis e manipular dados");
            ExecutarCalculadora();
        }

        private static void ExecutarCalculadora() 
        {            
            InformarValores(out double nValorA, out double nValorB);
            Calculadora calculadora = new Calculadora(nValorA, nValorB);
            Processador processador = new Processador(calculadora);

            processador.ExibirDadosProcessamento();            
        }        

        private static void InformarValores(out double nValorA, out double nValorB)
        {
            do { 
                Console.WriteLine("Digite o valor de A:"); 
            } while (!(Double.TryParse(Console.ReadLine(), out nValorA)));

            do
            {
                Console.WriteLine("Digite o valor de B:");
            } while (!(Double.TryParse(Console.ReadLine(), out nValorB)));             
        }
        
    }
}
