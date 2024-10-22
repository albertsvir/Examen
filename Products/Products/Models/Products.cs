
using System.ComponentModel.DataAnnotations;

namespace Products.Models
{
    public class Products
    {
        [Required(ErrorMessage = "El Inventario es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El Inventario debe ser mayor a 0")]
        public int? Inventario { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El Departamento es obligatorio")]
        public string? Departamento { get; set; }
    }
}
