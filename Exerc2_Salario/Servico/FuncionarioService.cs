using System;
using System.Collections.Generic;
using Exerc2_Salario.Entidade;

namespace Exerc2_Salario.Servico
{
    public class FuncionarioService
    {
        private int _quantidadeFuncionarios;
        private List<Funcionario> _funcionarios = new List<Funcionario>();

        public FuncionarioService()
        {
            InserirQuantidadeDeFuncionarios();
            RealizarEntradaDeFuncionarios();            
        }        

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            _funcionarios.Add(funcionario);
        }

        public Funcionario FuncionarioComMaiorSalario()
        {
            return _funcionarios[_quantidadeFuncionarios -1];
        }

        public Funcionario FuncionarioComMenorSalario()
        {
            return _funcionarios[0];
        }

        public void InserirQuantidadeDeFuncionarios()
        {
            do
            {
                Console.WriteLine("Entre com a quantidade de funcionários para verificação:");
            } while (!int.TryParse(Console.ReadLine(), out _quantidadeFuncionarios));
        }

        public void CadastrarFuncionario(int contador)
        {
            string sNome;
            double nSalario;
            
            Console.WriteLine($"Entre com o nome do funcionário: #{contador}.");
            sNome = Console.ReadLine();

            do
            {
                Console.WriteLine($"Entre com o salário do funcionário: #{contador}.");
            } while (!double.TryParse(Console.ReadLine(), out nSalario));

            Funcionario func = new Funcionario(sNome, nSalario);
            _funcionarios.Add(func);
        }

        private void RealizarEntradaDeFuncionarios()
        {
            for(int nContador = 1; nContador <= _quantidadeFuncionarios; nContador++)
            {
                CadastrarFuncionario(nContador);
            }
        }

        public void ApresentarFuncionarios() 
        {
            _funcionarios.Sort();
            ApresentarFuncionarioMenorSalario();
            ApresentarFuncionarioMaiorSalario();
        }

        public void ApresentarFuncionarioMenorSalario()
        {
            Console.WriteLine("Funcionario com menor salário");
            Console.WriteLine(FuncionarioComMenorSalario());

        }

        public void ApresentarFuncionarioMaiorSalario()
        {
            Console.WriteLine("Funcionario com Maior salário");
            Console.WriteLine(FuncionarioComMaiorSalario());
        }
    }
}
