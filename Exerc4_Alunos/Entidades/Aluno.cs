using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exerc4_Alunos.Entidades
{
    class Aluno
    {
        public string Nome { get; set; }        
        public double Media => CalcularMedia();

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
            double VerificaNota;

            try
            {
                VerificaNota = double.Parse(nota.Trim());
            }
            catch
            {
                throw new ArgumentException("Uma letra não pode ser digitada como nota.");
            }
             
            if(VerificaNota < 0 || VerificaNota > 10)
            {
                throw new ArgumentException("Digite uma nota entre 0 e 10.");
            }

            return VerificaNota;
        }        

        public override string ToString()
        {
            return $"Nome: {Nome}"
                + $" Media: {CalcularMedia().ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void TestarNotasValidas()
        {         
            Notas.ForEach(nota => PegarNota(nota));         
        }
    }
}
