using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc1_Demonstracao.Entidade
{
    public class PitBull: Cachorro
    {
        private int _ferocidade;
        public void LutarComOutrosCaes()
        {
            VisualizarOutroCao();
            AdicionarFerocidade();
            Falar();
            Falar();
        }

        public void AdicionarFerocidade()
        {
            _ferocidade += 10;
        }

        public void VisualizarOutroCao()
        {
            Console.WriteLine("Encontrou outro cão.");
        }
    }
}
