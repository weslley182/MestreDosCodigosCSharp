using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exerc1_Calculadora.Servicos;

namespace Exerc1_CalculadoraTest
{
    [TestClass]
    public class CalculadoraTest
    {

        private Calculadora _calc;
        const double deltaAproximacao = 0.0001;

        [TestInitialize]
        public void CriarCalculadora() => _calc = new Calculadora();        

        [TestMethod]
        public void TestarOperacaoSoma()
        {
            const double ValorSomaEsperado = 40;            
            _calc.ValorA = 10;
            _calc.ValorB = 30;

            var ResultadoSoma = _calc.Somar();

            Assert.AreEqual(ValorSomaEsperado, ResultadoSoma, deltaAproximacao);
        }

        [TestMethod]
        public void TestarOperacaoSubtracao()
        {
            const double ValorSomaEsperado = 20;
            _calc.ValorA = 30;
            _calc.ValorB = 10;

            var Resultado = _calc.Subtrair();

            Assert.AreEqual(ValorSomaEsperado, Resultado, deltaAproximacao);
        }

        [TestMethod]
        public void TestarOperacaoMultiplicacao()
        {
            const double ValorSomaEsperado = 200;
            _calc.ValorA = 20;
            _calc.ValorB = 10;

            var Resultado = _calc.Multiplicar();

            Assert.AreEqual(ValorSomaEsperado, Resultado, deltaAproximacao);
        }

        [TestMethod]
        public void TestarOperacaoDivisao()
        {
            const double ValorSomaEsperado = 2;
            _calc.ValorA = 10;
            _calc.ValorB = 20;

            var Resultado = _calc.Dividir();

            Assert.AreEqual(ValorSomaEsperado, Resultado, deltaAproximacao);
        }

        [TestMethod]
        public void TestarOperacaoDivisaoporZero()
        {
            const double ValorSomaEsperado = 0;
            _calc.ValorA = 0;
            _calc.ValorB = 20;

            var Resultado = _calc.Dividir();

            Assert.AreEqual(ValorSomaEsperado, Resultado, deltaAproximacao);
        }

        [TestMethod]
        public void TestarOperacaoDeveSerImpar()
        {
            const double ValorImpar = 3;

            Assert.IsFalse(_calc.TestarValorEhpar(ValorImpar));
        }

        [TestMethod]
        public void TestarOperacaoDeveSerPar()
        {
            const double ValorPar = 4;

            Assert.IsTrue(_calc.TestarValorEhpar(ValorPar));            
        }
    }
}
