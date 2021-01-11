using Exerc1_Demonstracao.Entidade.Caracteristica;
using System;
using System.Collections.Generic;
using System.Text;

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
