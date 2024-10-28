using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaLopez_Examen1P.Models
{
    public class ML_modelo1
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        
        public string? MLNombre { get; set; }
        public int MLEdad { get; set; }
        public string? MLDireccion { get; set; }
        [Required]
        public string? MLDepartamento { get; set; }
        public DateTime MLFechaNacimiento { get; set; }
        public bool MLIsCliente { get; set; }
        [Range(0, 1000000)]
        public decimal MLSaldo { get; set; }

    }
}
