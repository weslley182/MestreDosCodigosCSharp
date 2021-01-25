using Exerc1_Demonstracao.Entidade.Caracteristica;
using System;

namespace Exerc1_Demonstracao.Entidade
{
    public class PitBull: Cachorro, ITerritorial
    {
        private int _ferocidade;        

        public void LutarComOutrosCaes()
        {
            VisualizarOutroCao();
            AdicionarFerocidade();
            Falar();
            Falar();
            AdicionarTerritorial();
        }

        public void AdicionarFerocidade()
        {
            _ferocidade += 10;
            Console.WriteLine($"Cão feroz nivel: {_ferocidade}.");
        }

        public static void VisualizarOutroCao()
        {
            Console.WriteLine("Encontrou outro cão.");            
        }

        public void AdicionarTerritorial()
        {
            Console.WriteLine("Aqui ninguém entra, e se entrar morre.");
        }
    }
}
