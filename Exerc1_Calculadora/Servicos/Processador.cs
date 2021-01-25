using System;
using Exerc1_Calculadora.Entidades;
using System.Globalization;

namespace Exerc1_Calculadora.Servicos
{
    class Processador
    {
        private double _valorA;
        private double _valorB;

        private readonly ICalculadora _calculadora;
        public Processador(ICalculadora calculadora)
        {
            _calculadora = calculadora;            
        }

        public void InformarValores()
        {
            do
            {
                Console.WriteLine("Digite o valor de A:");
            } while (!Double.TryParse(Console.ReadLine(), out _valorA));

            do
            {
                Console.WriteLine("Digite o valor de B:");
            } while (!Double.TryParse(Console.ReadLine(), out _valorB));

            _calculadora.ValorA = _valorA;
            _calculadora.ValorB = _valorB;
        }

        private void ExibirResultado(string opcao) 
        {
            string sTexto = String.Empty;
            switch (opcao) 
            {
                case "1":
                    sTexto = _calculadora.Somar().ToString("F2", CultureInfo.InvariantCulture);
                    break;
                case "2":
                    sTexto = _calculadora.Subtrair().ToString("F2", CultureInfo.InvariantCulture);
                    break;
                case "3":
                    sTexto = _calculadora.Dividir().ToString("F2", CultureInfo.InvariantCulture);
                    break;
                case "4":
                    sTexto = _calculadora.Multiplicar().ToString("F2", CultureInfo.InvariantCulture);
                    break;
            }

            Console.WriteLine($"Opção {opcao} - Resultado: " + sTexto);
            Console.WriteLine(String.Empty);
        }

        public void ExibirDadosProcessamento()
        {
            
            Console.WriteLine("==Opções==");            
            Console.WriteLine("1 - Some esses 2 valores");
            Console.WriteLine("2 - Faça uma subtração do valor A - B");
            Console.WriteLine("3 - Divida o valor B por A");
            Console.WriteLine("4 - Multiplique o valor A por B");
            Console.WriteLine("5 - Imprima os valores de entrada, informado se o número é par ou ímpar");
            Console.WriteLine("6 - Digitar novos valores");
            Console.WriteLine("7 - Sair");            

            Console.WriteLine("Digite o número da opção desejada:");
            string sOpcao = Console.ReadLine();

            switch (sOpcao)
            {
                case "1":
                    ExibirResultado(sOpcao);
                    ExibirDadosProcessamento();
                    break;
                case "2":
                    ExibirResultado(sOpcao);                    
                    ExibirDadosProcessamento();
                    break;
                case "3":
                    ExibirResultado(sOpcao);
                    ExibirDadosProcessamento();
                    break;
                case "4":
                    ExibirResultado(sOpcao);
                    ExibirDadosProcessamento();
                    break;
                case "5":
                    Console.WriteLine($"Opção 5 - Resultado: A é { _calculadora.DescricaoValorA} e B é {_calculadora.DescricaoValorB}");
                    Console.WriteLine(String.Empty);
                    ExibirDadosProcessamento();
                    break;
                case "6":
                    InformarValores();
                    ExibirDadosProcessamento();
                    break;
                case "7":
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Opção inacessivel.");
                    Console.WriteLine(String.Empty);
                    ExibirDadosProcessamento();
                    break;
            }

        }
    }
}
