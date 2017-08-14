using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaInventario.Models
{
    public class RegistroSpares
    {
        [Key]


        public int SpareId { get; set; }
  
        [Required(ErrorMessage = "Datos Obligatorio")]
        public int AlmacenId { get; set; }

        [Required(ErrorMessage = "Datos Obligatorio")]
        [Display(Name = "Nombre del Spare")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Datos Obligatorio")]
        [Display(Name = "Numero de Parte")]
        public string NumeroParte { get; set; }

        [Required(ErrorMessage = "Datos Obligatorio")]
        [Display(Name = "Numero de Serial ")]
        public string SerialNumero { get; set; }

        [Required(ErrorMessage = "Datos Obligatorio")]
        public string Ubicacion { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }

        public virtual RegistroAlmacenes RegistroAlmacenes { get; set; }
        public virtual ICollection<DetalleAlmacenSpares> DetalleAlmacenSpares { get; set; }
    }
}