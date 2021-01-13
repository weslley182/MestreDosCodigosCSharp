using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exerc1_Calculadora.Servicos;

namespace Exerc1_CalculadoraTest
{
    [TestClass]
    public class CalculadoraTest
    {
        private Calculadora _calc;

        [TestInitialize]
        public void CriarCalculadora()
        {
            _calc = new Calculadora();
        }

        [TestMethod]
        public void TestarOperacaoSoma()
        {
            
            _calc.ValorA = 10;
            _calc.ValorB = 30;

            double nValorSomaEsperado = 40;
            Assert.AreEqual(nValorSomaEsperado, _calc.Somar(), 0.0001);
        }

        [TestMethod]
        public void TestarOperacaoSubtracao()
        {

            _calc.ValorA = 30;
            _calc.ValorB = 10;

            double nValorSomaEsperado = 20;
            Assert.AreEqual(nValorSomaEsperado, _calc.Subtrair(), 0.0001);
        }

        [TestMethod]
        public void TestarOperacaoMultiplicacao()
        {

            _calc.ValorA = 20;
            _calc.ValorB = 10;

            double nValorSomaEsperado = 200;
            Assert.AreEqual(nValorSomaEsperado, _calc.Multiplicar(), 0.0001);
        }

        [TestMethod]
        public void TestarOperacaoDivisao()
        {

            _calc.ValorA = 10;
            _calc.ValorB = 20;

            double nValorSomaEsperado = 2;
            Assert.AreEqual(nValorSomaEsperado, _calc.Dividir(), 0.0001);
        }

        [TestMethod]
        public void TestarOperacaoDivisaoporZero()
        {

            _calc.ValorA = 0;
            _calc.ValorB = 20;

            double nValorSomaEsperado = 0;
            Assert.AreEqual(nValorSomaEsperado, _calc.Dividir(), 0.0001);
        }

        [TestMethod]
        public void TestarOperacaoDeveSerImpar()
        {
            double nValorImpar = 3;
            Assert.IsFalse(_calc.TestarValorEhpar(nValorImpar));
        }

        [TestMethod]
        public void TestarOperacaoDeveSerPar()
        {
            double nValorPar = 4;            
            Assert.IsTrue(_calc.TestarValorEhpar(nValorPar));            
        }
    }
}
