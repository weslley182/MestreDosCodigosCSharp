using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exerc2_Pessoa.Entidade
{
    public class Pessoa
    {
        private readonly string _nome;

        private readonly DateTime _dataNascimento;

        private readonly double _altura;

        private int Idade { get { return BuscarIdade(); } }
        public Pessoa(string nome, DateTime dataNascimento, double altura)
        {
            _nome = nome;
            _dataNascimento = dataNascimento;
            _altura = altura;
        }

        private int BuscarIdade()
        {
            int idade = DateTime.Now.Year - _dataNascimento.Year;
            if(DateTime.Now.DayOfYear < _dataNascimento.DayOfYear)
            {
                return idade - 1;
            }
            return idade;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nome: ");
            sb.Append(_nome);
            sb.Append(", data de nascimento: ");
            sb.Append(_dataNascimento.ToString("dd/MM/yyyy"));
            sb.Append(", altura: ");
            sb.Append(_altura.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(", idade: ");
            sb.Append(Idade.ToString());
            return sb.ToString();
        }
    }
}
