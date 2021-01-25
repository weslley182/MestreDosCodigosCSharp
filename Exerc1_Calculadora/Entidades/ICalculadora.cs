namespace Exerc1_Calculadora.Entidades
{
    interface ICalculadora
    {
        double ValorA { get; set; }
        double ValorB { get; set; }
        string DescricaoValorA { get; }
        string DescricaoValorB { get; }
        public double Somar();
        public double Subtrair();
        public double Multiplicar();
        public double Dividir();        
    }
}
