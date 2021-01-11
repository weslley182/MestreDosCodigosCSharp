using Exerc1_Demonstracao.Entidade.Caracteristica;
using System;

namespace Exerc1_Demonstracao.Entidade
{
    public class PastorAlemao: Cachorro, ITerritorial
    {
        public void ProtegerCasa()
        {
            Falar();
            AdicionarTerritorial();
        }

        public void AdicionarTerritorial()
        {
            Console.WriteLine("Aqui ninguém entra.");
        }
    }
}
