﻿using System;
using System.Globalization;

namespace Exerc2_Salario.Entidade
{
    public class Funcionario: IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Funcionario))
            {
                throw new ArgumentException("Funcionário não é comparável.");
            }

            Funcionario outro = obj as Funcionario;
            return Salario.CompareTo(outro.Salario);
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Salário: {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
