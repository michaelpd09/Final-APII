using SistemaInventario.DAL;
using SistemaInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaInventario.BLL
{
    public class SparesBLL
    {
        public static bool Guardar(RegistroSpares spare)
        {
            bool retorno = false;
            try
            {
                var db = new InventarioDb();

                //  if (db.usuario.Find(usuario) != null)
                //        db.Entry(usuario).State = EntityState.Modified;
                //   else
                db.spare.Add(spare);

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