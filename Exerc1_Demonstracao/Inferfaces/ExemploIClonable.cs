using System;

namespace Exerc1_Demonstracao.Inferfaces
{
    public class Pessoa: ICloneable
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Endereco Endereco { get; set; }
        public Pessoa(string nome, int idade, Endereco endereco)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }

        public override string ToString()
        {
            return $"Nome {Nome}, idade: {Idade} anos, Endereço: Rua: {Endereco.Rua}, CEP: {Endereco.Cep}";            
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }        
    }

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
