namespace Estacionamento.Model
{
    public class Movimento
    {
        public int Seqmovto { get; set; }
        public string Placa { get; set; }
        public string Dtamovimento { get; set; }
        public string Dtahorentrada { get; set; }
        public string Dtahorsaida { get; set; }
        public decimal Vlrhora { get; set; }
        public decimal QtdeHora { get; set; }
        public decimal Vlrdesc { get; set; }
        public decimal Vlrtotal { get; set; }
        public int Seqconvenio { get; set; }
        public int Seqmodelo { get; set; }
        public int Status { get; set; }
        public string Motorista { get; set; }
        public string Ultnome { get; set; }
        public Modelo modelo { get; set; }
    }
}
