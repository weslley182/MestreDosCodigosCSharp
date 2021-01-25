using System;
using System.Collections.Generic;
using Exerc4_Alunos.Entidades;

namespace Exerc4_Alunos.Servicos
{
    public class AlunoServico
    {
        private List<Aluno> _listaAlunos = new List<Aluno>();        

        public void ApresentarMediasDosAlunos() 
        {            
            foreach(Aluno aluno in _listaAlunos)
            {
                if(aluno.CalcularMedia() > 7) 
                {
                    Console.WriteLine($"Alunos com media acima de 7: {aluno}");
                }                
            }
        }

        private void AdicionarAluno(Aluno aluno)
        {
            _listaAlunos.Add(aluno);
        }

        public void RealizarEntradaDeAlunos()
        {
            int quantidadeAlunos;
            string nome;
            string notas;
            do
            {
                Console.WriteLine("Quantos alunos serão verificados?");
            } while (!int.TryParse(Console.ReadLine(), out quantidadeAlunos));

            for(int contador = 1; contador <= quantidadeAlunos; contador++)
            {
                Console.WriteLine("Entre com o Nome do Aluno:");
                nome = Console.ReadLine();

                Console.WriteLine("Entre com as notas, separadas por ,(vírgula):");                
                notas = Console.ReadLine();

                Aluno aluno = new Aluno(nome, notas);
                aluno.TestarNotasValidas();
                AdicionarAluno(aluno);
            }

            
        }

    }
}
