using System;

namespace Exerc6_Diferenca.Servico
{
    public class CalculoOutRef
    {
        // ref só pode ser utilizado com variáveis iniciadas
        public void MetodoUtilizandoRef(ref int parametro)
        {
            try
            {
                parametro += 5;
            }
            catch
            {
                throw new InvalidOperationException("Variável utilizada deve ser iniciada.");
            }
        }

        // o out não precisa ser iniciado mas deve ser alterado
        public void MetodoUtilizandoOut(out int parametro)
        {
            try
            {
                parametro = 5;
            }
            catch
            {
                throw new InvalidOperationException();
            }
        }
    }
}
