namespace Estacionamento.Model
{
    public class Modelo
    {
        public int Seqmodelo { get; set; }
        public int Seqmarca { get; set; }
        public string Descricao { get; set; }
        public string Ultnome { get; set; }
        public Marca Marca { get; set; }
    }
}
