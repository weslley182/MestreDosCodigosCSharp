using Exerc5_Bhaskara.Servico;
using System;
using Xunit;

namespace Exerc5_BhaskaraTest
{
    public class Exerc5_BhaskaraTest
    {
        [Fact]
        public void TestarValorR1UmR2MenosNove()
        {   //1,8, -9 result = 1 e -9
            CalcularService serv = new CalcularService(1,8,-9);
            serv.CalcularFormula();
            Assert.Equal(serv.R1, 1);
            Assert.Equal(serv.R2, -9);
        }
    }
}
