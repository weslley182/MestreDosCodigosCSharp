using Exerc8_ListaOrdem.Servico;
using System;
using System.Linq;

namespace Exerc8_ListaOrdem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("8 - Faça uma aplicação ler N valores decimais, imprima os valores em ordem crescente e decrescente.");
            ListaService lista = new ListaService();
            lista.ExecutarLista();
        }
    }
}
