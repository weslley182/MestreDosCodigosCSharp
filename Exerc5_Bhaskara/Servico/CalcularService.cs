using System;
using System.Globalization;

namespace Exerc5_Bhaskara.Servico
{
    public class CalcularService
    {
        public int ValorA { get; set; }
        public int ValorB { get; set; }
        public int ValorC { get; set; }

        private double _R1;

        private double _R2;

        public CalcularService(int valorA, int valorB, int valorC)
        {
            ValorA = valorA;
            ValorB = valorB;
            ValorC = valorC;
        }

        public void CalcularFormula()
        {
            _R1 = (-ValorB + Math.Sqrt(ValorB * ValorB - 4 * ValorA * ValorC)) / (2 * ValorA);

            _R2 = (-ValorB - Math.Sqrt(ValorB * ValorB - 4 * ValorA * ValorC)) / (2 * ValorA);
        }

        public void MostrarResultado()
        {
            Console.WriteLine($"Valor de R1: {_R1.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de R2: {_R2.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
