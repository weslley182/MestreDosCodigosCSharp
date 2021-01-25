using Exerc4_Alunos.Servicos;

namespace Exerc4_Alunos
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("4 - Faça uma aplicação que receba N alunos com suas respectivas notas. Use foreach para a estrutura de repetição.");
            AlunoServico serv = new AlunoServico();
            serv.RealizarEntradaDeAlunos();
            serv.ApresentarMediasDosAlunos();
        }
    }
}
