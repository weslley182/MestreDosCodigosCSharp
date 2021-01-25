namespace Exerc1_Demonstracao.Entidade
{
    public abstract class Animal
    {
        private string _nome;
        public abstract void Falar();

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string valor)
        {
            _nome = valor;
        }

    }


}
