using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc6_Diferenca.Servico
{
    public class CalculoOutRef
    {
        // ref só pode ser utilizado com variáveis iniciadas
        public void MetodoUtilizandoRef(ref int paramX)
        {
            try
            {
                paramX += 5;
            }
            catch
            {
                throw new InvalidOperationException("Variável utilizada deve ser iniciada.");
            }
        }

        // o out não precisa ser iniciado mas deve ser alterado
        public void MetodoUtilizandoOut(out int paramX)
        {
            try
            {
                paramX = 5;
            }
            catch
            {
                throw new InvalidOperationException();
            }
        }
    }
}
