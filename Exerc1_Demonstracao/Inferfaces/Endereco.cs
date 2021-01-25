namespace Exerc1_Demonstracao.Inferfaces
{
    public class Endereco
    {        
        public string Rua { get; set; }
        public string Cep { get; set; }
        public Endereco(string rua, string cep)
        {
            Rua = rua;
            Cep = cep;
        }

    }
}
