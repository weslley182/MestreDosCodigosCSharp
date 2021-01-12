using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exerc7_SomaPares.Servico;

namespace Exerc7_SomaParesTest
{
    [TestClass]
    public class CalculaSomaParServicoTest
    {
        CalculaSomaParServico _serv;

        [TestInitialize]
        public void IniciarConstrutor()
        {
            _serv = new CalculaSomaParServico();
        }
        [TestMethod]
        public void TestarSomaDeValoresPares()
        {
            _serv.Lista.Add(1);
            _serv.Lista.Add(10);
            _serv.Lista.Add(1);
            _serv.Lista.Add(1);
            _serv.Lista.Add(1);
            _serv.Lista.Add(1);
            _serv.Lista.Add(1);

            _serv.RealizarCalculo();
            Assert.AreEqual(10, _serv.ValorTotal);
        }
    }
}
