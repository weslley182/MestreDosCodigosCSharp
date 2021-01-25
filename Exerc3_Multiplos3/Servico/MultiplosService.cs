using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc3_Multiplos3.Servico
{
    public class MultiplosService
    {
        private readonly int _valor;
        public List<int> Lista { get; init; }
        
        public MultiplosService(int multiplo)
        {
            _valor = multiplo;
            Lista = new List<int>();
        }

        public bool TestarEhMultiplo(int contador)
        {
            return (contador % _valor == 0);
        }

        public void BuscarMultiplosAteh(int quantidade)
        {
            int nContador = 1;
            do
            {
                if (TestarEhMultiplo(nContador))
                {
                    Lista.Add(nContador);
                }
                
                nContador++;
            } while (nContador <= quantidade);            
        }

        private int RetornarValor(int valor)
        {
            if (TestarEhMultiplo(valor))
            {
                return valor;
            }
            return 0;
        }
    }
}
