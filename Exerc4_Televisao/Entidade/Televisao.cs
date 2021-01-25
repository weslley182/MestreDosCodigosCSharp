using System.Collections.Generic;

namespace Exerc4_Televisao.Entidade
{
    public class Televisao
    {
        private int _volume;
        private int _numeroCanal;

        public int Volume
        {
            get => _volume;
            set => _volume = TestarValorEhValido(value) ? value : _volume;
        }

        public int NumeroCanal
        {
            get => _numeroCanal;
            set => _numeroCanal = TestarValorEhValido(value) ? value : _numeroCanal;
        }

        public string InformarDadosCanal()
        {
            var achou = (ListaCanais.Find(item => item.Numero == NumeroCanal));
            if (achou == null)
            {
                return $"Canal {NumeroCanal} não encontrado";
            }

            return $"Canal {achou.Numero} - {achou.Descricao}";
        }
        public bool TestarValorEhValido(int valor)
        {
            return (valor >= 0) || (valor <= 100);
        }
        public void AumentarVolume()
        {
            Volume += 1;
        }

        public void DiminuirVolume()
        {
            Volume -= 1;
        }

        public void AumentarNumeroCanal()
        {
            NumeroCanal += 1;
        }

        public void DiminuirNumeroCanal()
        {
            NumeroCanal -= 1;
        }

        public List<Canal> ListaCanais = new List<Canal>();
        public void SintonizarCanais()
        {
            ListaCanais.Add(new Canal(3, "TV Globo"));
            ListaCanais.Add(new Canal(7, "SBT"));
            ListaCanais.Add(new Canal(13, "Record"));
            ListaCanais.Add(new Canal(22, "Manchete"));
            ListaCanais.Add(new Canal(39, "Rede Vida"));
            ListaCanais.Add(new Canal(42, "Multishow"));
            ListaCanais.Add(new Canal(45, "ESPN"));
            ListaCanais.Add(new Canal(55, "Combate"));
        }

        public Televisao()
        {
            SintonizarCanais();
            Volume = 20;
        }
    }
}
