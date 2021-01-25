using System;
using Exerc2_Pessoa.Entidade;

namespace Exerc2_Pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 - Crie uma classe para representar uma pessoa:");
            Console.WriteLine("Entre com os dados da Pessoa:");

            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Data de nascimento no formato dd/MM/yyyy:");
            string[] data = Console.ReadLine().Split("/");
            
            Console.WriteLine("Altura da pessoa separada por vírgula: (0,00)");
            double altura = double.Parse(Console.ReadLine());


            int dia = int.Parse(data[0]);
            int mes = int.Parse(data[1]);
            int ano = int.Parse(data[2]);

            Pessoa pessoa = new Pessoa(nome, new DateTime(ano,mes,dia), altura);
            Console.WriteLine(pessoa);
        }
    }
}
