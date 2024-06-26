namespace PruebaTecnicaCovisian.Models
{
    public class Alquiler
    {
        public int IdAlquiler { get; set; }
        public string Placa { get; set; }
        public string Cedula { get; set; }
        public DateTime Fecha { get; set; }
        public int TiempoEnDias { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Saldo { get; set; }
        public bool Devuelto { get; set; }
    }
}
