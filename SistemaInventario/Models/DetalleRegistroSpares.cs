using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaInventario.Models
{
    public class DetalleRegistroSpares
    {
        [Key]


        public int SpareId { get; set; }
  
        [Required(ErrorMessage = "Datos Obligatorio")]
        public int AlmacenId { get; set; }

        [Required(ErrorMessage = "Datos Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Datos Obligatorio")]
        public string NumeroParte { get; set; }

        [Required(ErrorMessage = "Datos Obligatorio")]
        public string SerialNumero { get; set; }

        [Required(ErrorMessage = "Datos Obligatorio")]
        public string Ubicacion { get; set; }

        public DateTime Fecha { get; set; }

        public virtual RegistroAlmacenes RegistroAlmacenes { get; set; }
    }
}