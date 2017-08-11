using SistemaInventario.DAL;
using SistemaInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaInventario.BLL
{
    public class TiposBLL
    {
        public static bool Guardar(TiposUsuarios tipos)
        {
            bool retorno = false;
            try
            {
                var db = new InventarioDb();

                //  if (db.usuario.Find(usuario) != null)
                //        db.Entry(usuario).State = EntityState.Modified;
                //   else
                db.tipos.Add(tipos);

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