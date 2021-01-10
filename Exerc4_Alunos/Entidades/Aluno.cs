using System;
using System.Globalization;

namespace Exerc4_Alunos.Entidades
{
    class Aluno
    {
        public string Nome { get; set; }
        public string[] Notas { get; set; }
        public double Media { get { return CalcularMedia(); } }

        public double CalcularMedia()
        {
            double total = 0;
            for (int i = 0; i<= Notas.Length-1; i++)
            {
                double nNota = PegarNota(i);
                total += nNota;
            }

            return (total / Notas.Length);
        }

        private double PegarNota(int i)
        {
            double nota;

            try
            {
                nota = double.Parse(Notas[i].Trim());
            }
            catch
            {
                throw new ArgumentException("Uma letra não pode ser digitada como nota.");
            }
             
            if(nota < 0 || nota > 10)
            {
                throw new ArgumentException("Digite uma nota entre 0 e 10.");
            }

            return nota;
        }

        public Aluno(string nome, string[] notas)
        {
            Nome = nome;
            Notas = (string[])notas.Clone();         
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                + " Media: " + CalcularMedia().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void TestarNotasValidas()
        {
            for (int i = 0; i <= Notas.Length - 1; i++)
            {
                double nNota = PegarNota(i);            
            }
        }
    }
}
