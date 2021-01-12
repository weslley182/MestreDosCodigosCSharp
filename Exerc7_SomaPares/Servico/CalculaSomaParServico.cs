using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc7_SomaPares.Servico
{
    public class CalculaSomaParServico
    {        
        public List<int> Lista { get; set; }

        private int _valor;
        public int ValorTotal { get; set; }

        public CalculaSomaParServico()
        {
            Lista = new List<int>();
        }
        private bool TestarEhPar(int numero)
        {
            return (numero % 2 == 0);
        }

        public void RealizarCalculo()
        {
            foreach (int numero in Lista)
            {
                if (TestarEhPar(numero))
                {
                    ValorTotal += numero;
                }
            }
        }

        public void Ler4Numeros()
        {
            for (int i = 1; i <= 4; i++)
            {
                do
                {
                    Console.WriteLine($"Entre com o valor #{i}:");
                } while (!int.TryParse(Console.ReadLine(), out _valor));

                Lista.Add(_valor);
            }
        }

        public override string ToString()
        {
            return $"Soma dos valores pares é: {ValorTotal}";
        }
    }
}
