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
            string sNome = Console.ReadLine();

            Console.WriteLine("Data de nascimento no formato dd/MM/yyyy:");
            string[] sData = Console.ReadLine().Split("/");
            
            Console.WriteLine("Altura da pessoa separada por vírgula: (0,00)");
            double nAltura = double.Parse(Console.ReadLine());


            int nDia = int.Parse(sData[0]);
            int nMes = int.Parse(sData[1]);
            int nAno = int.Parse(sData[2]);

            Pessoa pessoa = new Pessoa(sNome, new DateTime(nAno,nMes,nDia), nAltura);
            Console.WriteLine(pessoa);
        }
    }
}
