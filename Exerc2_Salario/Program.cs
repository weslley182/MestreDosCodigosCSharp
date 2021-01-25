using Exerc2_Salario.Servico;

namespace Exerc2_Salario
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("2 - Crie uma aplicação que receba nome e salário de N funcionários. Utilize a repetição for e while.");
            FuncionarioService serv = new FuncionarioService();
            serv.ApresentarFuncionarios();
        }
    }
}
