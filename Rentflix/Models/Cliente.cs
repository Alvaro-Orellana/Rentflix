using System;
using System.ComponentModel.DataAnnotations;

namespace Rentflix.Models
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [StringLength(255)]
        public string Nombre { get; set; }

        [Display(Name = "Esta subscrito")]
        public bool EstaSubscrito { get; set; }

        [Display(Name = "Tipo de membresia")]
        public virtual TipoMembresia TipoMembresia { get; set; }

        public byte TipoMembresiaId { get; set; }

        [Min18EdadParaMembresia]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

    }
}
