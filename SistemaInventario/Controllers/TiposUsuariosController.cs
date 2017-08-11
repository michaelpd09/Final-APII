using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaInventario.DAL;
using SistemaInventario.Models;
using SistemaInventario.BLL;

namespace SistemaInventario.Controllers
{
    public class TiposUsuariosController : Controller
    {
        private InventarioDb db = new InventarioDb();

        // GET: TiposUsuarios
        public ActionResult Index()
        {
            return View(db.tipos.ToList());
        }

        // GET: TiposUsuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiposUsuarios tiposUsuarios = db.tipos.Find(id);
            if (tiposUsuarios == null)
            {
                return HttpNotFound();
            }
            return View(tiposUsuarios);
        }

        // GET: TiposUsuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiposUsuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( TiposUsuarios tiposUsuarios)
        {
            if (ModelState.IsValid)
            {
                TiposBLL.Guardar(tiposUsuarios);
                return RedirectToAction("Index");
            }

            return View(tiposUsuarios);
        }

        // GET: TiposUsuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiposUsuarios tiposUsuarios = db.tipos.Find(id);
            if (tiposUsuarios == null)
            {
                return HttpNotFound();
            }
            return View(tiposUsuarios);
        }

        // POST: TiposUsuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TiposUsuariosId,Nombre,Fecha")] TiposUsuarios tiposUsuarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tiposUsuarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tiposUsuarios);
        }

        // GET: TiposUsuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiposUsuarios tiposUsuarios = db.tipos.Find(id);
            if (tiposUsuarios == null)
            {
                return HttpNotFound();
            }
            return View(tiposUsuarios);
        }

        // POST: TiposUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TiposUsuarios tiposUsuarios = db.tipos.Find(id);
            db.tipos.Remove(tiposUsuarios);
          
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                //throw new Exception("No se puedo borrar porque esta asociado a un usuario, intente borrar el usuario primero!!!", ex);
              
            }
            
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
