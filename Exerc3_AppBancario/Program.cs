using System;
using Exerc3_AppBancario.Entidade;

namespace Exerc3_AppBancario
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("3 - Faça uma aplicação bancária.");
            RealizarAcaoContaCorrente();
            RealizarAcaoContaEspecial();
        }

        private static void RealizarAcaoContaCorrente()
        {
            ContaCorrente conta = new ContaCorrente("745509-2", 2000, 3);
            try
            {
                Console.WriteLine(conta.MostrarDados());
                Console.WriteLine("Deposito de 15");
                conta.Depositar(15);
                Console.WriteLine(conta.MostrarDados());
                Console.WriteLine("Saque de 1500");
                conta.Sacar(1500);
                Console.WriteLine(conta.MostrarDados());
                Console.WriteLine("Saque de 3000");
                conta.Sacar(3000);
                Console.WriteLine(conta.MostrarDados());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void RealizarAcaoContaEspecial()
        {
            ContaEspecial conta = new ContaEspecial("738819-1", 2000, 1000);
            try
            {
                Console.WriteLine(conta.MostrarDados());
                Console.WriteLine("Deposito de 15");
                conta.Depositar(15);
                Console.WriteLine(conta.MostrarDados());
                Console.WriteLine("Saque de 3000");
                conta.Sacar(3000);
                Console.WriteLine(conta.MostrarDados());
                Console.WriteLine("saque de 1500");
                conta.Sacar(1500);
                Console.WriteLine(conta.MostrarDados());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
