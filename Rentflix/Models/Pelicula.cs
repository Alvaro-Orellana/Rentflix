using System;
using System.ComponentModel.DataAnnotations;

namespace Rentflix.Models
{
    public class Pelicula
    {
        public Pelicula()
        {
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [StringLength(255)]
        public String Nombre { get; set; }

        [Display(Name = "Fecha de estreno")]
        [Required(ErrorMessage = "El campo Fecha de estreno es requerido")]
        public DateTime FechaEstreno { get; set; }

        [Display(Name = "Cantidad en stock")]
        [Required(ErrorMessage = "Debe agregar el numero de peliculas en stock")]
        [MinStockPermitido]
        public ushort CantidadEnStock { get; set; }

        public virtual Genero Genero { get; set; }

        public byte GeneroId { get; set; }

        public string ImageURL { get; set; }
    }

  
}
