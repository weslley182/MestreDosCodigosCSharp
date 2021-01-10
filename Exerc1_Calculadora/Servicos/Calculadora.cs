using Exerc1_Calculadora.Entidades;
    
namespace Exerc1_Calculadora.Servicos
{
    public class Calculadora : ICalculadora
    {
        public double ValorA { get; set; }
        public double ValorB { get; set; }
        public string DescricaoValorA { get { return PegarDescricaoValorParImpar(ValorA); } }
        public string DescricaoValorB { get { return PegarDescricaoValorParImpar(ValorB); } }
        

        public double Somar()
        {
            return ValorA + ValorB;
        }

        public double Subtrair()
        {
            return ValorA - ValorB;
        }

        public double Multiplicar()
        {
            return ValorA * ValorB;
        }
        public double Dividir()
        {
            if(ValorA == 0)
            {
                return 0;
            }
            return ValorB / ValorA;
        }

        private bool TestarValorEhpar(double valor)
        {
            return (valor % 2 == 0);
        }

        private string PegarDescricaoValorParImpar(double valor)
        {
            return TestarValorEhpar(valor) ? "Par" : "Ímpar";
        }
        
    }

}
