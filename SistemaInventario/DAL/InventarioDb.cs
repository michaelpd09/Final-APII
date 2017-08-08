using SistemaInventario.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaInventario.DAL
{
    public class InventarioDb:DbContext
    {
        public InventarioDb(): base("ConStr")
        {

        }
        public DbSet<RegistroUsuarios> usuario { get; set; }
        public DbSet<RegistroAlmacenes> almacen { get; set; }
        public DbSet<RegistroSpares> spare { get; set; }
        public DbSet<DetalleAlmacenSpares> detalle { get; set; }
    }
}