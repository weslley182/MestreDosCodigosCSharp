using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exerc4_Alunos.Entidades
{
    class Aluno
    {
        public string Nome { get; set; }
        // public string[] Notas { get; set; }        
        public double Media { get { return CalcularMedia(); } }

        public List<string> Notas = new List<string>();

        public Aluno(string nome, string notas)
        {
            Nome = nome;

            string[] sNotas = notas.Split(",");
            for (int i = 0; i<= sNotas.Length -1; i++)
            {
                Notas.Add(sNotas[i]);
            }
            
        }

        public double CalcularMedia()
        {
            double total = 0;
            foreach (string nota in Notas)
            {                
                double nNota = PegarNota(nota);
                total += nNota;
            }

            return (total / Notas.Count);
        }

        private double PegarNota(string nota)
        {
            double nNota;

            try
            {
                nNota = double.Parse(nota.Trim());
            }
            catch
            {
                throw new ArgumentException("Uma letra não pode ser digitada como nota.");
            }
             
            if(nNota < 0 || nNota > 10)
            {
                throw new ArgumentException("Digite uma nota entre 0 e 10.");
            }

            return nNota;
        }        

        public override string ToString()
        {
            return "Nome: " + Nome
                + " Media: " + CalcularMedia().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void TestarNotasValidas()
        {
            double nNota;
            foreach (string nota in Notas)
            {
                nNota = PegarNota(nota);
            }
        }
    }
}
