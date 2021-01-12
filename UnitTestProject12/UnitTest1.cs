using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using 

namespace UnitTestProject12
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculadora calc = new Calculadora();
            calc.ValorA = 10;
            calc.ValorB = 30;

            double nValorSomaEsperado = 40;
            Assert.AreEqual(nValorSomaEsperado, calc.Somar(), 0.0001);
        }
    }
}
