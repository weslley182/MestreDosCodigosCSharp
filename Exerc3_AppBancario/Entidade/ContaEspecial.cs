using System;
using System.Globalization;

namespace Exerc3_AppBancario.Entidade
{
    public class ContaEspecial : ContaBancaria, IImprimivel
    {
        public double Limite { get; set; }

        public ContaEspecial(string numero, double saldo, double limite) : base(numero, saldo)
        {            
            Limite = limite;
        }

        public override void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            if ((Saldo + Limite - valor) < 0)
            {
                throw new InvalidOperationException($"Conta Especial Nº{NumeroConta} não possui saldo suficiente.");
            }
            Saldo -= valor;
        }

        public string MostrarDados()
        {
            return $"Conta Especial Nº{ NumeroConta} Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}" +
                $", limite de: {Limite.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
