using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc1_Demonstracao.Inferfaces
{
    class BancoDeDados : IDisposable
    {
        public string Tipo { get; set; }

        public BancoDeDados(string tipo)
        {
            Tipo = tipo;
        }

        public void ConsultaDadosBancoDados()
        {
            ConectaBancoDeDados();
            RealizaConsultaBancoDados();
        }

        private void ConectaBancoDeDados()
        {
            Console.WriteLine($"Conectando com banco de dados {Tipo}");
        }

        private void RealizaConsultaBancoDados()
        {
            Console.WriteLine($"Realizando consulta banco de dados {Tipo}");
        }

        public void Dispose()
        {
            Console.WriteLine($"Entrou no dispose, liberou banco {Tipo}");
        }
    }
}
