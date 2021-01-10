using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc3_Multiplos3.Servico
{
    public class MultiplosService
    {
        private readonly int _valor;
        public MultiplosService(int multiplo)
        {
            _valor = multiplo;
        }

        private bool TestarEhMultimplo(int contador)
        {
            return (contador % _valor == 0);
        }

        public void MostrarMultiplosAteh100() 
        {
            int nContador = 1;
            do
            {
                if (TestarEhMultimplo(nContador))
                {
                    Console.WriteLine(nContador);
                }
                nContador++;
            } while (nContador <= 100);
        }
    }
}
