using System.ComponentModel.DataAnnotations;

namespace MaLopez_Examen1P.Models
{
    public class ML_modelo1
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Direccion { get; set; }
        [Required]
        public string Departamento { get; set; }
        public bool IsCliente { get; set; }
        [Range(0, 1000000)]
        public decimal Saldo { get; set; }

    }
}
