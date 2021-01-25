using Xunit;
using Exerc3_Multiplos3.Servico;

namespace Exerc3_Multiplos3Test
{
    public class MultiplosServiceTest
    {
        
        [Fact]
        public void TestarSeNumerosInformadosSaoMultiplosDeTres()
        {
            MultiplosService serv = new MultiplosService(3);
            serv.BuscarMultiplosAteh(10);

            foreach(int valor in serv.Lista)
            {
                Assert.True((valor % 3 == 0));
            }
        }
    }
}
