

namespace Exerc1_Demonstracao.Entidade
{
    abstract public class Animal
    {
        private string _nome;        
        abstract public void Falar();

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
