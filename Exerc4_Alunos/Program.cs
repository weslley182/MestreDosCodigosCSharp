using Exerc4_Alunos.Servicos;

namespace Exerc4_Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoServico serv = new AlunoServico();
            serv.RealizarEntradaDeAlunos();
            serv.ApresentarMediasDosAlunos();
        }
    }
}
