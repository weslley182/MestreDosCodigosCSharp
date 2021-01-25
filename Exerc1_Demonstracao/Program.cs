using System;
using Exerc1_Demonstracao.Entidade;
using Exerc1_Demonstracao.Inferfaces;
using Exerc1_Demonstracao.Servico;
using Exerc1_Demonstracao.Entidade.Caracteristica;


namespace Exerc1_Demonstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Responda e demonstre no código os itens abaixo:");
            ExecutarExemplosDePOOBasico();
            ExecutarExemploIComparable();
            ExecutarExemploIEnumerable();
            ExecutarExemploIDisposable();
            ExecutarExemploIClonable();
        }

        private static void ExecutarExemplosDePOOBasico() 
        {
            //Abastração, polimosfismo, encapsulamento, quando usar interface
            Console.WriteLine("Utilizando fundamentos básicos de POO");
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

            ITerritorial pit2 = new PitBull();
            Console.WriteLine("Segundo Pit Bull");
            pit.AdicionarTerritorial();

            PastorAlemao pastor = new PastorAlemao();
            Console.WriteLine("Pastor alemão");
            pastor.ProtegerCasa();
            Console.WriteLine(String.Empty);
        }

        private static void ExecutarExemploIComparable()
        {            
            ExemploIComparableService.Executar();
        }

        private static void ExecutarExemploIEnumerable()
        {            
            Console.WriteLine("Exemplo utilizando IEnumerable");
            Console.WriteLine("Possibilidade de iterar a Array de Pilotos contida dentro da de Fórmula 1");

            Formula1 corrida = new Formula1(20);

            foreach (Piloto piloto in corrida)
            {
                Console.WriteLine(piloto.Nome);
            }
            Console.WriteLine(String.Empty);
        }

        private static void ExecutarExemploIDisposable()
        {
            
            Console.WriteLine("Exemplo utilizando IDisposable");            

            BancoDeDados bd = new BancoDeDados("SQLServer");
            try
            {
                bd.ConsultaDadosBancoDados();
            }
            finally
            {
                bd.Dispose();
            }
            Console.WriteLine(String.Empty);
        }

        private static void ExecutarExemploIClonable()
        {
            Console.WriteLine("Exemplo utilizando IClonable");
            Pessoa wesley = new Pessoa("Wesley Machado", 37, new Endereco("Kiri", "16057-560"));
            Pessoa wesleyIrmao = (Pessoa)wesley.Clone(); // Clona os valores dos atributos            

            Console.WriteLine(wesley);
            Console.WriteLine(wesleyIrmao);            
            Console.WriteLine();            
        }

    }
}
