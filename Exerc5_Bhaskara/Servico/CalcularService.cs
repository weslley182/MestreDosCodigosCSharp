using System;
using System.Globalization;

namespace Exerc5_Bhaskara.Servico
{
    public class CalcularService
    {
        public int ValorA { get; set; }
        public int ValorB { get; set; }
        public int ValorC { get; set; }

        public double R1 { get; set; }
        public double R2 { get; set; }        

        public CalcularService(int valorA, int valorB, int valorC)
        {
            ValorA = valorA;
            ValorB = valorB;
            ValorC = valorC;
        }

        public void CalcularFormula()
        {
            R1 = (-ValorB + Math.Sqrt(ValorB * ValorB - 4 * ValorA * ValorC)) / (2 * ValorA);

            R2 = (-ValorB - Math.Sqrt(ValorB * ValorB - 4 * ValorA * ValorC)) / (2 * ValorA);
        }
        
    }
}
