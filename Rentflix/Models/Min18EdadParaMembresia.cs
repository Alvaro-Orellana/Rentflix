﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Rentflix.Models
{
    public class Min18EdadParaMembresia: ValidationAttribute
    {
        public Min18EdadParaMembresia()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var cliente = (Cliente)validationContext.ObjectInstance;
            

            // Si la membresia elegida es pago al contado no se necesita validacion adicional
            if (cliente.TipoMembresiaId == TipoMembresia.PagoAlContado)
                return ValidationResult.Success;

            // Si la mebresia elegida no es pago al contado validar que existe fecha de nacimiento
            if (cliente.FechaNacimiento == null)
                return new ValidationResult("Fecha de nacimiento es requerida");


            // Verificar que el cliente es mayor de edad para completar la validacion
            const byte EDAD_MINIMA_PARA_MEMBRESIA = 18;

            var edadCliente = DateTime.Today.Year - cliente.FechaNacimiento.Value.Year;
            var meseDesdeCumpleAños = DateTime.Today.Month - cliente.FechaNacimiento.Value.Month;
            var diasDesdeCumpleaños = DateTime.Today.Day - cliente.FechaNacimiento.Value.Day;


            if(edadCliente > EDAD_MINIMA_PARA_MEMBRESIA)
            {
                return ValidationResult.Success;

            } else if (edadCliente == EDAD_MINIMA_PARA_MEMBRESIA && meseDesdeCumpleAños >= 0 && diasDesdeCumpleaños >= 0)
            {

                return ValidationResult.Success;

            } else
            {
                return new ValidationResult("El cliente debe tener al menos 18 años para contratar una mebresía");
            }

            //return (edadCliente >= EDAD_MINIMA_PARA_MEMBRESIA)
            //    ? ValidationResult.Success
            //    : new ValidationResult("El cliente debe tener al menos 18 años para contratar una mebresía");
        }
    }
}
