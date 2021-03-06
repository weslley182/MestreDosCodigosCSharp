using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exerc2_Pessoa.Entidade
{
    public class Pessoa
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private DateTime _dataNascimento;
        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }

        private double _altura;

        public double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }
        
        
        public Pessoa(string nome, DateTime dataNascimento, double altura)
        {
            _nome = nome;
            _dataNascimento = dataNascimento;
            _altura = altura;
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
