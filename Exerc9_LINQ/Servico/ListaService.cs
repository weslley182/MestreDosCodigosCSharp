using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exerc9_LINQ.Servico
{
    public class ListaService
    {
        private readonly List<int> _listaNumeros = new List<int>();

        private const string sNUMERO = "Digite um número inteiro ou digite : Sair";

        public void Executar()
        {
            InserirNumeros();
            ImprimirNumerosListaOrdemInsercao();
            ImprimirNumerosListaOrdemCrescente();
            ImprimirNumerosListaOrdemDecrescente();
            ImprimirPrimeiroDaLista();
            ImprimirUltimoDaLista();
            AdicionarNumeroInicioListaExibir();
            AdicionarNumeroFinalListaExibir();
            RemoverPrimeiroNumeroListaExibir();
            RemoverUltimoNumeroListaExibir();
            ImprimirApenasNumerosPares();
            ImprimirNumeroInformado();
            ImprimirListaEmArray();
        }
        private void InserirNumeros()
        {
            while (true)
            {
                Console.WriteLine(sNUMERO);


                SolicitarNumeroValido(out string valorDigitado, out int valorInteiro);

                if (valorDigitado.ToUpper() == "SAIR")
                {
                    break;
                }                    

                _listaNumeros.Add(valorInteiro);
            }
            
        }
        private void SolicitarNumeroValido(out string sair, out int numero)
        {
            while
                    (
                        ((sair = Console.ReadLine()).Length == 0) ||
                        ((!int.TryParse(sair, out numero)) && (sair.ToUpper() != "SAIR"))
                    )
            {
                Console.WriteLine("Valor inválido.");
                Console.WriteLine(sNUMERO);
            }
        }        

        private void ApresentarListaOrdemPadrao()
        {
            _listaNumeros.ForEach(n => Console.Write(n));
            Console.WriteLine(String.Empty);
        }
        private void ImprimirNumerosListaOrdemInsercao()
        {
            Console.WriteLine("Apresentação da lista");
            ApresentarListaOrdemPadrao();
        }

        private void ImprimirNumerosListaOrdemCrescente()
        {
            Console.WriteLine("Apresentação da lista em ordem crescente.");
            _listaNumeros
                .OrderBy(n => n)
                .ToList()
                .ForEach(n => Console.Write(n));
            Console.WriteLine(String.Empty);
        }

        private void ImprimirNumerosListaOrdemDecrescente()
        {
            Console.WriteLine("Apresentação da lista em ordem decrescente.");
            _listaNumeros
                .OrderByDescending(n => n)
                .ToList()
                .ForEach(n =>Console.Write(n));
            Console.WriteLine(String.Empty);
        }

        private void ImprimirPrimeiroDaLista()
        {
            Console.WriteLine("Apresentação do primeiro número da lista.");
            Console.Write(_listaNumeros.First().ToString());
            Console.WriteLine(String.Empty);
        }

        private void ImprimirUltimoDaLista()
        {
            Console.WriteLine("Apresentação do último número da lista.");
            Console.Write(_listaNumeros.Last().ToString());
            Console.WriteLine(String.Empty);
        }
        private void AdicionarNumeroInicioListaExibir()
        {

            Console.WriteLine("Apresentação de lista inserindo número no início.");

            SolicitarNumeroValido(out string sair, out int valorInicio);
            if (sair.ToUpper() == "SAIR")
            {
                return;
            }

            _listaNumeros.Insert(0, valorInicio);

            ApresentarListaOrdemPadrao();
        }
        private void AdicionarNumeroFinalListaExibir()
        {

            Console.WriteLine("Apresentação de lista inserindo número no final.");

            SolicitarNumeroValido(out string sair, out int valorFinal);
            if(sair.ToUpper() == "SAIR")
            {
                return;
            }

            _listaNumeros.Add(valorFinal);

            ApresentarListaOrdemPadrao();            
        }

        private void RemoverPrimeiroNumeroListaExibir()
        {
            Console.WriteLine("Apresentação de lista removendo número inicial.");
            _listaNumeros.RemoveAt(0);
            ApresentarListaOrdemPadrao();
        }
        private void RemoverUltimoNumeroListaExibir()
        {
            Console.WriteLine("Apresentação de lista removendo número no final.");
            _listaNumeros.RemoveAt(_listaNumeros.Count - 1);
            ApresentarListaOrdemPadrao();
        }

        private void ImprimirApenasNumerosPares()
        {
            Console.WriteLine("Apresentação de números pares da lista.");
            _listaNumeros
                .Where(item => ((item % 2) == 0))
                .ToList()
                .ForEach(item => Console.WriteLine(item));
            Console.WriteLine(String.Empty);
        }

        private void ImprimirNumeroInformado()
        {

            Console.WriteLine("Apresentação de número informado.");

            SolicitarNumeroValido(out string sair, out int valor);
            if (sair.ToUpper() == "SAIR")
            {
                return;
            }

            _listaNumeros
                .Where(item => item == valor)
                .ToList()
                .ForEach(item => Console.WriteLine(item));

            Console.WriteLine(String.Empty);
        }

        private void ImprimirListaEmArray()
        {
            Console.WriteLine("Imprimir lista em Array.");
            foreach (int numero in _listaNumeros.ToArray())
            {
                Console.Write(numero);
            }
            Console.WriteLine(String.Empty);
        }
    }
}
