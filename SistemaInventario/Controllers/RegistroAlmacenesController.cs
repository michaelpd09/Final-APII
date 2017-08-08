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
    public class RegistroAlmacenesController : Controller
    {
        private InventarioDb db = new InventarioDb();

        // GET: RegistroAlmacenes
        public ActionResult Index()
        {
            return View(db.almacen.ToList());
        }

        // GET: RegistroAlmacenes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroAlmacenes registroAlmacenes = db.almacen.Find(id);
            if (registroAlmacenes == null)
            {
                return HttpNotFound();
            }
            return View(registroAlmacenes);
        }

        // GET: RegistroAlmacenes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistroAlmacenes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( RegistroAlmacenes registroAlmacenes)
        {
            if (ModelState.IsValid)
            {
                AlmacenesBLL.Guardar(registroAlmacenes);
                return RedirectToAction("Index");
            }

            return View(registroAlmacenes);
        }

        // GET: RegistroAlmacenes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroAlmacenes registroAlmacenes = db.almacen.Find(id);
            if (registroAlmacenes == null)
            {
                return HttpNotFound();
            }
            return View(registroAlmacenes);
        }

        // POST: RegistroAlmacenes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AlmacenId,Nombre,Ubicacion,Fecha")] RegistroAlmacenes registroAlmacenes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registroAlmacenes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registroAlmacenes);
        }

        // GET: RegistroAlmacenes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroAlmacenes registroAlmacenes = db.almacen.Find(id);
            if (registroAlmacenes == null)
            {
                return HttpNotFound();
            }
            return View(registroAlmacenes);
        }

        // POST: RegistroAlmacenes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegistroAlmacenes registroAlmacenes = db.almacen.Find(id);
            db.almacen.Remove(registroAlmacenes);
            db.SaveChanges();
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
