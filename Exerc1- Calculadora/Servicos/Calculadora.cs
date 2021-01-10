using Exerc1_Calculadora.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
    
namespace Exerc1_Calculadora.Servicos
{
    public class Calculadora : ICalculadora
    {
        private readonly double _valorA;
        private readonly double _valorB;

        public string DescricaoValorA { get { return PegarDescriçaoValorParImpar(_valorA); } }
        public string DescricaoValorB { get { return PegarDescriçaoValorParImpar(_valorB); } }


        public Calculadora(double valorA, double valorB)
        {
            _valorA = valorA;
            _valorB = valorB;
        }

        public double Somar()
        {
            return _valorA + _valorB;
        }

        public double Subtrair()
        {
            return _valorA - _valorB;
        }

        public double Multiplicar()
        {
            return _valorA * _valorB;
        }
        public double Dividir()
        {
            if(_valorA == 0)
            {
                return 0;
            }
            return _valorB / _valorA;
        }

        private bool TestarValorEhpar(double valor)
        {
            return (valor % 2 == 0);
        }

        private string PegarDescriçaoValorParImpar(double valor)
        {
            return TestarValorEhpar(valor) ? "Par" : "Ímpar";
        }
        
    }

}
