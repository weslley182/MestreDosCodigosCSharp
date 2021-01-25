using System;

namespace Exerc1_Demonstracao.Inferfaces
{
    public class Pessoa: ICloneable
    {
        public Pessoa(string nome, int idade, Endereco endereco)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Endereco Endereco { get; set; }
        

        public override string ToString()
        {
            return $"Nome {Nome}, idade: {Idade} anos, Endereço: Rua: {Endereco.Rua}, CEP: {Endereco.Cep}";            
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }        
    }
    
}
