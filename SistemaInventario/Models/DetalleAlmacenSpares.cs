using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaInventario.Models
{
    public class DetalleAlmacenSpares
    {
        [Key]

       
        public int DetalleAlmacenSpareId { get; set; }

        [Display(Name = "Spare")]
        public int SpareId { get; set; }
        [Display(Name = "Almacen ")]
        public int AlmacenId { get; set; }

        [Required(ErrorMessage = "Tecnologia Obligatoria")]
        public string Tecnologia { get; set; }

        public DateTime Fecha { get; set; }

       
        public virtual RegistroSpares RegistroSpares { get; set; }
        public virtual RegistroAlmacenes RegistroAlmacen { get; set; }
     
        
    }
}