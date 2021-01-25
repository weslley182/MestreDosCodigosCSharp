namespace Exerc4_Televisao.Entidade
{
    public class ControleRemoto
    {
        private readonly Televisao tv;

        public ControleRemoto(Televisao televisao)
        {
            tv = televisao;
        }

        public void AumentarVolume()
        {
            tv.AumentarVolume();
        }

        public void DiminuirVolume()
        {
            tv.DiminuirVolume();
        }

        public string AumentarNumeroCanal()
        {
            tv.AumentarNumeroCanal();
            return tv.InformarDadosCanal();
        }

        public string DiminuirNumeroCanal()
        {
            tv.DiminuirNumeroCanal();
            return tv.InformarDadosCanal();
        }

        public string ConsultarVolumeCanal()
        {
            return $"Volume {tv.Volume}"
                + $" - {tv.InformarDadosCanal()}";
        }

        public string InformarNumeroCanal(int numero)
        {
            tv.NumeroCanal = numero;
            return tv.InformarDadosCanal();
        }

    }
}
