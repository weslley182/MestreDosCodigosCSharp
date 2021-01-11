using System;
using System.Collections.Generic;
using System.Text;
using Exerc1_Demonstracao.Inferfaces;

namespace Exerc1_Demonstracao.Servico
{
    public static class ExemploIComparableService
    {
        public static void Executar()
        {
            Console.WriteLine("Exemplo de utilização IComparable.");

            List<Funcionario> lista = new List<Funcionario>();

            Funcionario funcionario = new Funcionario("Alex", 3000);
            lista.Add(funcionario);

            Funcionario funcionario2 = new Funcionario("Will", 2000);
            lista.Add(funcionario2);

            Funcionario funcionario3 = new Funcionario("Maria", 1000);
            lista.Add(funcionario3);

            Console.WriteLine("Apresentação da lista antes de ser reordenada.");
            foreach (Funcionario func in lista)
            {
                Console.WriteLine(func);
            }

            lista.Sort();
            Console.WriteLine("Apresentação da lista após de ser reordenada. com a a classe Funcionario comparando o Salário.");
            foreach (Funcionario func in lista)
            {
                Console.WriteLine(func);
            }
            Console.WriteLine(String.Empty);
        }
    }
}
