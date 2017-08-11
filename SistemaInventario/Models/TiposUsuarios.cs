using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaInventario.Models
{
    public class TiposUsuarios
    {

        public int TiposUsuariosId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Nombre Obligatorio")]
        [Display(Name = "Cargo ")]
        public string Nombre { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }

        public virtual ICollection<RegistroUsuarios> RegistroUsuarios { get; set; }
    }
}