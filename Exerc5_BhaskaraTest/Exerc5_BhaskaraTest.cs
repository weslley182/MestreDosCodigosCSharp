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

            Assert.Equal(1, serv.R1);
            Assert.Equal(-9, serv.R2);
        }
    }
}
