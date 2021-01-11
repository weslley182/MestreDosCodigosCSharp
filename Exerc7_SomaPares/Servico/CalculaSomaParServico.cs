using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc7_SomaPares.Servico
{
    public class CalculaSomaParServico
    {
        List<int> lista = new List<int>();

        private int _valor;

        private int _valorTotal = 0;
        private bool TestarEhPar(int numero)
        {
            return (numero % 2 == 0);
        }

        public void RealizarCalculo()
        {
            foreach (int numero in lista)
            {
                if (TestarEhPar(numero))
                {
                    _valorTotal += numero;
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

                lista.Add(_valor);
            }
        }

        public override string ToString()
        {
            return $"Soma dos valores pares é: {_valorTotal}";
        }
    }
}
