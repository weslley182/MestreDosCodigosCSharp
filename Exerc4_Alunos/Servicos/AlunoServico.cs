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
                Console.WriteLine(aluno);
            }
        }

        private void AdicionarAluno(Aluno aluno)
        {
            _listaAlunos.Add(aluno);
        }

        public void RealizarEntradaDeAlunos()
        {
            int nQuantidadeAlunos;
            string sNome;
            string[] sNotas;
            do
            {
                Console.WriteLine("Quantos alunos serão verificados?");
            } while (!int.TryParse(Console.ReadLine(), out nQuantidadeAlunos));

            for(int nContador = 1; nContador <= nQuantidadeAlunos; nContador++)
            {
                Console.WriteLine("Entre com o Nome do Aluno:");
                sNome = Console.ReadLine();

                Console.WriteLine("Entre com as notas, separadas por ,(vírgula):");                
                sNotas = Console.ReadLine().Split(",");

                Aluno aluno = new Aluno(sNome, sNotas);
                aluno.TestarNotasValidas();
                AdicionarAluno(aluno);
            }

            
        }

    }
}
