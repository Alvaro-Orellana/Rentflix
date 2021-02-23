﻿using System.ComponentModel.DataAnnotations;

namespace Rentflix.Models
{
    public class Genero
    {
        public Genero()
        {
        }

        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }
    }



}