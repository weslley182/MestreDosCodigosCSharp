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
        }

        public void VisualizarOutroCao()
        {
            Console.WriteLine("Encontrou outro cão.");
        }

        public void AdicionarTerritorial()
        {
            Console.WriteLine("Aqui ninguém entra, e se entrar morre.");
        }
    }
}
