using System;
using System.Globalization;

namespace Exerc3_AppBancario.Entidade
{
    public class ContaCorrente : ContaBancaria, IImprimivel
    {
        public double TaxaDeOperacao { get; set; }

        public ContaCorrente(string numero, double saldo, double taxa) : base(numero, saldo)
        {
            TaxaDeOperacao = taxa;
        }
        public override void Depositar(double valor)
        {
            Saldo += (valor - TaxaDeOperacao); ;
        }

        public override void Sacar(double valor)
        {
            if ((Saldo - valor) < 0)
            {
                throw new InvalidOperationException($"Conta Corrente Nº{NumeroConta} não possui saldo suficiente.");
            }

            Saldo -= TaxaDeOperacao;
            Saldo -= valor;
        }

        public string MostrarDados()
        {
            return $"Conta Corrente Nº{ NumeroConta} Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}" +
                $", Taxa de {TaxaDeOperacao.ToString("F2", CultureInfo.InvariantCulture)}";                
        }
    }
}
