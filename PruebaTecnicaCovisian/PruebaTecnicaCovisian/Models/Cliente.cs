using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaCovisian.Models
{
    public class Cliente
    {
        [Key]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
    }
}
