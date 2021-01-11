using System;
using System.Collections.Generic;
using Exerc1_Demonstracao.Entidade;
using Exerc1_Demonstracao.Servico;

namespace Exerc1_Demonstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutarExemplosDePOOBasico();
            ExecutarExemploIComparable();
        }

        private static void ExecutarExemplosDePOOBasico() 
        {
            //Abastração, polimosfismo, encapsulamento, quando usar interface
            Animal cachorro = new Cachorro();
            Console.WriteLine("Cachorro");
            cachorro.SetNome("Thor");
            cachorro.Falar();


            Animal gato = new Gato();
            Console.WriteLine("Gato");
            gato.SetNome("Frodo");
            gato.Falar();

            PitBull pit = new PitBull();
            Console.WriteLine("Pit Bull");
            pit.LutarComOutrosCaes();

            PastorAlemao pastor = new PastorAlemao();
            Console.WriteLine("Pastor alemão");
            pastor.ProtegerCasa();
            Console.WriteLine(String.Empty);
        }

        private static void ExecutarExemploIComparable()
        {
            ExemploIComparableService.Executar();
        }

        
    }
}
