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
            cachorro.SetNome("Thor");
            cachorro.Falar();


            Animal gato = new Gato();
            gato.SetNome("Frodo");
            gato.Falar();
        }

        
    }
}
