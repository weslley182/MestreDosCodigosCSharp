using Exerc2_Salario.Servico;
using System;

namespace Exerc2_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioService serv = new FuncionarioService();
            serv.ApresentarFuncionarios();
        }
    }
}
