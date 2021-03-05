using System;
using System.Collections.Generic;
using Exerc2_Salario.Entidade;

namespace Exerc2_Salario.Servico
{
    public class FuncionarioService
    {
        private int _quantidadeFuncionarios;
        private Funcionario _funcMaiorSalario;
        private Funcionario _funcMenorSalario;
        private readonly List<Funcionario> _funcionarios = new List<Funcionario>();

        public FuncionarioService()
        {
            InserirQuantidadeDeFuncionarios();
            RealizarEntradaDeFuncionarios();            
        }        

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            _funcionarios.Add(funcionario);
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
            string nome;
            double salario;
            
            Console.WriteLine($"Entre com o nome do funcionário: #{contador}.");
            nome = Console.ReadLine();

            do
            {
                Console.WriteLine($"Entre com o salário do funcionário: #{contador}.");
            } while (!double.TryParse(Console.ReadLine(), out salario));

            Funcionario func = new Funcionario(nome, salario);
            _funcionarios.Add(func);
        }

        private void RealizarEntradaDeFuncionarios()
        {
            for(int contador = 1; contador <= _quantidadeFuncionarios; contador++)
            {
                CadastrarFuncionario(contador);
            }
        }

        public void ApresentarFuncionarios() 
        {
            ProcessarSalarioFuncionarios();
            ApresentarFuncionarioMenorSalario();
            ApresentarFuncionarioMaiorSalario();
        }
        private void ProcessarSalarioFuncionarios() 
        {
            
            _funcMenorSalario = _funcionarios[0];
            _funcMaiorSalario = _funcionarios[0];
            for (int i = 0; i < _funcionarios.Count; i++)
            {
                if (_funcionarios[i].Salario > _funcMaiorSalario.Salario)
                {
                    _funcMaiorSalario = _funcionarios[i];
                }

                if (_funcionarios[i].Salario < _funcMenorSalario.Salario)
                {
                    _funcMenorSalario = _funcionarios[i];
                }
            }
        }
        public void ApresentarFuncionarioMenorSalario()
        {
            Console.WriteLine("Funcionario com menor salário");
            Console.WriteLine(_funcMenorSalario);

        }

        public void ApresentarFuncionarioMaiorSalario()
        {
            Console.WriteLine("Funcionario com Maior salário");
            Console.WriteLine(_funcMaiorSalario);
        }
    }
}
