using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc1_Demonstracao.Entidade
{
    public class PastorAlemao: Cachorro
    {
        public void ProtegerCasa()
        {
            Falar();
            Console.WriteLine("Vigília constante");
        }
    }
}
