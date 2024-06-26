using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaCovisian.Models
{
    public class Carro
    {
        [Key]
        public string Placa { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public decimal Costo { get; set; }
        [Required]
        public bool Disponible { get; set; }
    }
}
