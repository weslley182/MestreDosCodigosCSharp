using Exerc1_Calculadora.Entidades;
    
namespace Exerc1_Calculadora.Servicos
{
    public class Calculadora : ICalculadora
    {
        public double ValorA { get; set; }
        public double ValorB { get; set; }
        public string DescricaoValorA => PegarDescricaoValorParImpar(ValorA);
        public string DescricaoValorB => PegarDescricaoValorParImpar(ValorB);



        public double Somar() => ValorA + ValorB;        

        public double Subtrair() => ValorA - ValorB;        

        public double Multiplicar() => ValorA * ValorB;
        
        public double Dividir() => (ValorA == 0 ? 0 : ValorB / ValorA);

        public bool TestarValorEhpar(double valor) => (valor % 2 == 0);        

        private string PegarDescricaoValorParImpar(double valor)
        {
            return TestarValorEhpar(valor) ? "Par" : "Ímpar";
        }
        
    }

}
