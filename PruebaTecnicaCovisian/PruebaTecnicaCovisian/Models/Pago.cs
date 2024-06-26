using System;
using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaCovisian.Models
{
    public class Pago
    {
        [Key]
        public int IdPago { get; set; }
        [Required]
        public int IdAlquiler { get; set; }
        [Required]
        public DateTime FechaPago { get; set; }
        [Required]
        public decimal ValorPago { get; set; }
    }
}
