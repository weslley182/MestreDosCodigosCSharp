namespace Exerc3_AppBancario.Entidade
{
    abstract public class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public double Saldo { get; set; }

        public abstract void Sacar(double valor);
        public abstract void Depositar(double valor);

        protected ContaBancaria(string numeroConta, double saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }
    }
}
