using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exerc2_Pessoa.Entidade
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Altura { get; set; }
        
        public Pessoa(string nome, DateTime dataNascimento, double altura)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Altura = altura;
        }

        private int BuscarIdade()
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;
            if(DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
            {
                return idade - 1;
            }
            return idade;
        }

        public override string ToString() =>        
            new StringBuilder()
                .Append("Nome: ")
                .Append(Nome)
                .Append(", data de nascimento: ")
                .Append(DataNascimento.ToString("dd/MM/yyyy"))
                .Append(", altura: ")
                .Append(Altura.ToString("F2", CultureInfo.InvariantCulture))
                .Append(", idade: ")
                .Append(BuscarIdade())
                .ToString();            
        
    }
}
