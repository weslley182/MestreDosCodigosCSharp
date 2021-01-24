using System;
using Exerc1_Calculadora.Servicos;

namespace Exerc1_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Crie uma aplicação, que receba os valores A e B. Mostre de forma simples, como utilizar variáveis e manipular dados");
            ExecutarCalculadora();
        }

        private static void ExecutarCalculadora() 
        {                        
            Calculadora calculadora = new Calculadora();
            Processador processador = new Processador(calculadora);

            processador.ExibirDadosProcessamento();            
        }                
        
    }
}
