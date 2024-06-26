using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace T3_RamosUyhua_CristhianJhon.Models
{
    public class Libro
    {
        [Key]

        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre del Titulo es obligatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El Nombre del Autor es obligatorio")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "El Nombre del Tema es obligatorio")]
        public string Tema { get; set; }
        [Required(ErrorMessage = "El Nombre de la Editorial es obligatorio")]
        public string Editorial { get; set; }
        [Required(ErrorMessage = "El Anio de Publicacion es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El Anio de Publicacion debe ser entre 1900 y 3000")]
        public string AnioPublicacion { get; set; }
        [Required(ErrorMessage = "El numero de Paginas es obligatorio")]
        [Range(10, 1000, ErrorMessage = "Las Paginas debe ser entre 10 y 1000")]
        public string Paginas { get; set; }
        [Required(ErrorMessage = "La Categoria es obligatoria")]
        public string Categoria { get; set; }

    }
}
