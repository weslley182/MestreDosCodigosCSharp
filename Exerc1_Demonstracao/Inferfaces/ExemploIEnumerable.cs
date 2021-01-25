using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exerc1_Demonstracao.Inferfaces
{
    class Piloto
    {
        public string Nome { get; init; }

        public Piloto(string nome)
        {
            Nome = nome;
        }
    }

    class Formula1 : IEnumerable
    {
        private readonly Piloto[] pilotos;
        public Formula1(int quantidadePilotos)
        {
            pilotos = new Piloto[quantidadePilotos];
            for(int i = 0; i < quantidadePilotos; i++)
            {
                pilotos[i] = new Piloto($"Piloto #{i}");
            }            
        }

        public IEnumerator GetEnumerator()
        {
            return pilotos.GetEnumerator();
        }
    }
}
