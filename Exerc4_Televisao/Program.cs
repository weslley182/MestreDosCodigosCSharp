using Exerc4_Televisao.Servico;

namespace Exerc4_Televisao
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("4 - Crie uma classe Televisao e uma classe ControleRemoto que pode controlar o volume e trocar os canais da televisão. O controle permite:");
            TelevisaoService serv = new TelevisaoService();
            serv.Executar();
        }

        
    }
}
