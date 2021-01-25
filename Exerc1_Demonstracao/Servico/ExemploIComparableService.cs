using System;
using System.Collections.Generic;
using System.Text;
using Exerc2_Salario.Entidade;

namespace Exerc1_Demonstracao.Servico
{
    public static class ExemploIComparableService
    {
        public static void Executar()
        {
            Console.WriteLine("Exemplo de utilização IComparable.");            
            
            var lista = new List<Funcionario>
            {
                 new Funcionario("Alex", 3000),
                 new Funcionario("Will", 5000),
                 new Funcionario("Maria", 1000),
            };            

            Console.WriteLine("Apresentação da lista antes de ser reordenada.");
            lista.ForEach(func => Console.WriteLine(func));            

            lista.Sort();
            Console.WriteLine("Apresentação da lista após de ser reordenada. com a a classe Funcionario comparando o Salário.");
            
            lista.ForEach(func => Console.WriteLine(func));
            
            Console.WriteLine(String.Empty);
        }
    }
}
