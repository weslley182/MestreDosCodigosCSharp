namespace Exerc4_Televisao.Entidade
{
    public class Canal
    {
        public int Numero { get; set; }
        public string Descricao { get; set; }
        public Canal(int numero, string desc)
        {
            Numero = numero;
            Descricao = desc;
        }
    }
}
