using System;
using Exerc1_Demonstracao.Entidade;


namespace Exerc1_Demonstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de polimorfismo
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

        
    }
}
