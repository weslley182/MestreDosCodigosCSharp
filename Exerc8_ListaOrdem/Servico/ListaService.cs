using System;
using System.Linq;

namespace Exerc8_ListaOrdem.Servico
{
    public class ListaService
    {
        private int[] _numeros;
        private int _quantidade;

        public void ExecutarLista()
        {
            PegarQuantidadedeEntradas();
            PegarTodasAsEntradas();
            ImprimirListaOrdemCrescente();
            ImprimirListaOrdemDecrescente();
        }
        private void PegarQuantidadedeEntradas()
        {            
            do
            {
                Console.WriteLine("Entre com a quantidade de números que serão digitados");
            } while (!int.TryParse(Console.ReadLine(), out _quantidade));

            _numeros = new int[_quantidade];
        }

        private void PegarTodasAsEntradas()
        {
            int valor;

            for (int i = 0; i < _quantidade; i++)
            {
                do
                {
                    Console.WriteLine($"Entre com o {i + 1}º valor");
                } while (!int.TryParse(Console.ReadLine(), out valor));
                _numeros[i] = valor;
            }
        }
        private void ImprimirListaOrdemCrescente()
        {            
            Console.WriteLine("Imprimir lista em ordem crescente:");

            _numeros = _numeros.OrderBy(c => c).ToArray();
            
            foreach (int numero in _numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine("");
        }

        private void ImprimirListaOrdemDecrescente()
        {
            Console.WriteLine("Imprimir lista em ordem decrescente:");

            _numeros = _numeros.OrderByDescending(c => c).ToArray();

            foreach (int numero in _numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine("");
        }

    }
}
