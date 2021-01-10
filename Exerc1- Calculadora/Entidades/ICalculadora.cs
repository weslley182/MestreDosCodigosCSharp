using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc1_Calculadora.Entidades
{
    public interface ICalculadora
    {
        string DescricaoValorA { get; }
        string DescricaoValorB { get; }
        public double Somar();
        public double Subtrair();
        public double Multiplicar();
        public double Dividir();        
    }
}
