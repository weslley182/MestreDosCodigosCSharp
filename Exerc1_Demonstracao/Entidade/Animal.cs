using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc1_Demonstracao.Entidade
{
    abstract public class Animal
    {
        public int Tamanho { get; set; }
        public int Peso { get; set; }
        public string Cor { get; set; }
        abstract public void Falar();
    }


}
