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
    public class DetalleAlmacenSparesController : Controller
    {
        private InventarioDb db = new InventarioDb();

        // GET: DetalleAlmacenSpares
        public ActionResult Index()
        {
            var detalle = db.detalle.Include(d => d.RegistroAlmacen).Include(d => d.RegistroSpares);
            return View(detalle.ToList());
        }

        // GET: DetalleAlmacenSpares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleAlmacenSpares detalleAlmacenSpares = db.detalle.Find(id);
            if (detalleAlmacenSpares == null)
            {
                return HttpNotFound();
            }
            return View(detalleAlmacenSpares);
        }

        // GET: DetalleAlmacenSpares/Create
        public ActionResult Create()
        {
            ViewBag.AlmacenId = new SelectList(db.almacen, "AlmacenId", "Nombre");
            ViewBag.SpareId = new SelectList(db.spare, "SpareId", "Nombre");
            return View();
        }

        // POST: DetalleAlmacenSpares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DetalleAlmacenSpareId,SpareId,AlmacenId,Tecnologia,Fecha")] DetalleAlmacenSpares detalleAlmacenSpares)
        {
            if (ModelState.IsValid)
            {
                db.detalle.Add(detalleAlmacenSpares);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AlmacenId = new SelectList(db.almacen, "AlmacenId", "Nombre", detalleAlmacenSpares.AlmacenId);
            ViewBag.SpareId = new SelectList(db.spare, "SpareId", "Nombre", detalleAlmacenSpares.SpareId);
            return View(detalleAlmacenSpares);
        }

        // GET: DetalleAlmacenSpares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleAlmacenSpares detalleAlmacenSpares = db.detalle.Find(id);
            if (detalleAlmacenSpares == null)
            {
                return HttpNotFound();
            }
            ViewBag.AlmacenId = new SelectList(db.almacen, "AlmacenId", "Nombre", detalleAlmacenSpares.AlmacenId);
            ViewBag.SpareId = new SelectList(db.spare, "SpareId", "Nombre", detalleAlmacenSpares.SpareId);
            return View(detalleAlmacenSpares);
        }

        // POST: DetalleAlmacenSpares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DetalleAlmacenSpareId,SpareId,AlmacenId,Tecnologia,Fecha")] DetalleAlmacenSpares detalleAlmacenSpares)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalleAlmacenSpares).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AlmacenId = new SelectList(db.almacen, "AlmacenId", "Nombre", detalleAlmacenSpares.AlmacenId);
            ViewBag.SpareId = new SelectList(db.spare, "SpareId", "Nombre", detalleAlmacenSpares.SpareId);
            return View(detalleAlmacenSpares);
        }

        // GET: DetalleAlmacenSpares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleAlmacenSpares detalleAlmacenSpares = db.detalle.Find(id);
            if (detalleAlmacenSpares == null)
            {
                return HttpNotFound();
            }
            return View(detalleAlmacenSpares);
        }

        // POST: DetalleAlmacenSpares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DetalleAlmacenSpares detalleAlmacenSpares = db.detalle.Find(id);
            db.detalle.Remove(detalleAlmacenSpares);
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
