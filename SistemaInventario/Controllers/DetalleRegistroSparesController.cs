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

namespace SistemaInventario.Controllers
{
    public class DetalleRegistroSparesController : Controller
    {
        private InventarioDb db = new InventarioDb();

        // GET: DetalleRegistroSpares
        public ActionResult Index()
        {
            var spare = db.spare.Include(d => d.RegistroAlmacenes);
            return View(spare.ToList());
        }

        // GET: DetalleRegistroSpares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleRegistroSpares detalleRegistroSpares = db.spare.Find(id);
            if (detalleRegistroSpares == null)
            {
                return HttpNotFound();
            }
            return View(detalleRegistroSpares);
        }

        // GET: DetalleRegistroSpares/Create
        public ActionResult Create()
        {
            ViewBag.AlmacenId = new SelectList(db.almacen, "AlmacenId", "Nombre");
            return View();
        }

        // POST: DetalleRegistroSpares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SpareId,AlmacenId,Nombre,NumeroParte,SerialNumero,Ubicacion,Fecha")] DetalleRegistroSpares detalleRegistroSpares)
        {
            if (ModelState.IsValid)
            {
                db.spare.Add(detalleRegistroSpares);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AlmacenId = new SelectList(db.almacen, "AlmacenId", "Nombre", detalleRegistroSpares.AlmacenId);
            return View(detalleRegistroSpares);
        }

        // GET: DetalleRegistroSpares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleRegistroSpares detalleRegistroSpares = db.spare.Find(id);
            if (detalleRegistroSpares == null)
            {
                return HttpNotFound();
            }
            ViewBag.AlmacenId = new SelectList(db.almacen, "AlmacenId", "Nombre", detalleRegistroSpares.AlmacenId);
            return View(detalleRegistroSpares);
        }

        // POST: DetalleRegistroSpares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SpareId,AlmacenId,Nombre,NumeroParte,SerialNumero,Ubicacion,Fecha")] DetalleRegistroSpares detalleRegistroSpares)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalleRegistroSpares).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AlmacenId = new SelectList(db.almacen, "AlmacenId", "Nombre", detalleRegistroSpares.AlmacenId);
            return View(detalleRegistroSpares);
        }

        // GET: DetalleRegistroSpares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleRegistroSpares detalleRegistroSpares = db.spare.Find(id);
            if (detalleRegistroSpares == null)
            {
                return HttpNotFound();
            }
            return View(detalleRegistroSpares);
        }

        // POST: DetalleRegistroSpares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DetalleRegistroSpares detalleRegistroSpares = db.spare.Find(id);
            db.spare.Remove(detalleRegistroSpares);
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
