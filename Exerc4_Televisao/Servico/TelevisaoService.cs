using System;
using Exerc4_Televisao.Entidade;

namespace Exerc4_Televisao.Servico
{
    class TelevisaoService
    {
        public Televisao TV { get; set; }

        public ControleRemoto Controle { get; set; }
        
        public void Executar()
        {
            TV = new Televisao();
            Controle = new ControleRemoto(TV);
            MostrarOpcoesDoControle();
        }

        private void MostrarOpcoesDoControle()
        {
            Console.WriteLine(String.Empty);            
            Console.WriteLine("Controle remoto");            
            Console.WriteLine("1 - Aumentar potência do volume");
            Console.WriteLine("2 - Diminuir potência do volume");
            Console.WriteLine("3 - Aumentar número do canal");
            Console.WriteLine("4 - Diminuir número do canal");
            Console.WriteLine("5 - Informar um número para trocar de canal");
            Console.WriteLine("6 - Consultar valor do volume de som e canal selecionado");
            Console.WriteLine("7 - Sair");            
            Console.WriteLine(String.Empty);

            Console.WriteLine("Digite a opção desejada:");
            string sSelecao = Console.ReadLine();

            switch (sSelecao)
            {
                case "1":
                    Controle.AumentarVolume();
                    Console.WriteLine($"Volume: {TV.Volume}");
                    MostrarOpcoesDoControle();
                    break;
                case "2":
                    Controle.DiminuirVolume();
                    Console.WriteLine($"Volume: {TV.Volume}");
                    MostrarOpcoesDoControle();
                    break;
                case "3":
                    Console.WriteLine("{0}", Controle.AumentarNumeroCanal());
                    MostrarOpcoesDoControle();
                    break;
                case "4":
                    Console.WriteLine("{0}", Controle.DiminuirNumeroCanal());
                    MostrarOpcoesDoControle();
                    break;
                case "5":
                    Console.WriteLine("Qual número de canal?");
                    int numeroCanal = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0}", Controle.InformarNumeroCanal(numeroCanal));
                    MostrarOpcoesDoControle();
                    break;
                case "6":
                    Console.WriteLine("{0}", Controle.ConsultarVolumeCanal());
                    MostrarOpcoesDoControle();
                    break;
                case "7":
                    break;
            }
        }
    }
}


