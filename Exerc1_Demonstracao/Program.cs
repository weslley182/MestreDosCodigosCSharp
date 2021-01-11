using System;
using System.Collections.Generic;
using Exerc1_Demonstracao.Entidade;
using Exerc1_Demonstracao.Inferfaces;

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
        }

        private static void ExecutarExemploIComparable()
        {
            List<Funcionario> lista = new List<Funcionario>();            

            Funcionario funcionario = new Funcionario("Alex", 3000);
            lista.Add(funcionario);

            Funcionario funcionario2 = new Funcionario("Will", 2000);
            lista.Add(funcionario2);

            Funcionario funcionario3 = new Funcionario("Maria", 1000);
            lista.Add(funcionario3);

            Console.WriteLine("Apresentação da lista antes de ser reordenada.");
            foreach(Funcionario func in lista)
            {
                Console.WriteLine(func);
            }

            lista.Sort();
            Console.WriteLine("Apresentação da lista após de ser reordenada. com a a classe Funcionario comparando o Salário.");
            foreach (Funcionario func in lista)
            {
                Console.WriteLine(func);
            }
        }

        
    }
}
