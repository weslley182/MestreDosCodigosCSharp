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

        public bool TestarEhMultiplo(int contador) => (contador % _valor == 0);        

        public void BuscarMultiplosAteh(int quantidade)
        {
            int contador = 1;
            do
            {
                if (TestarEhMultiplo(contador))
                {
                    Lista.Add(contador);
                }
                
                contador++;
            } while (contador <= quantidade);            
        }        
    }
}
