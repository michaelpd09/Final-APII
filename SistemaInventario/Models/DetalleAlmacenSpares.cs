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

        public int DetalleAlmacenSparesId { get; set; }

        public int AlmacenId { get; set; }
        public int SpareId { get; set; }

    }
}