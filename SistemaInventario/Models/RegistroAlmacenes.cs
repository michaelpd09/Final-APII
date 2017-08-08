﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaInventario.Models
{
    public class RegistroAlmacenes
    {
        [Key]

        public int AlmacenId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Nombre Obligatorio")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "Tipo Obligatorio")]
        public string Ubicacion { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }
    }
}