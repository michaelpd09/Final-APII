using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaInventario.Models
{
    public class TiposUsuarios
    {
        public int TiposUsuariosId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }

        public virtual ICollection<RegistroUsuarios> RegistroUsuarios { get; set; }
    }
}