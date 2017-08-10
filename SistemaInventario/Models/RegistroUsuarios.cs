using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaInventario.Models
{
    public class RegistroUsuarios
    {
        [Key]

        public int UsuarioId { get; set; }

        public int TiposUsuariosId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Nombre Obligatorio")]
        public string Nombre { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Apellido Obligatorio")]
        public string Apellido { get; set; }


        [Required(ErrorMessage = "La Clave es Obligatorio")]
        [DataType(DataType.Password)]
        public string Clave { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }

        public virtual TiposUsuarios TiposUsuarios { get; set; }

    }
}