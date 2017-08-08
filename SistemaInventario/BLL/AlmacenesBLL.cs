using SistemaInventario.DAL;
using SistemaInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaInventario.BLL
{
    public class AlmacenesBLL
    {
        public static bool Guardar(RegistroAlmacenes almacen)
        {
            bool retorno = false;
            try
            {
                var db = new InventarioDb();

                //  if (db.usuario.Find(usuario) != null)
                //        db.Entry(usuario).State = EntityState.Modified;
                //   else
                db.almacen.Add(almacen);

                db.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }

            return retorno;
        }
    }
}