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
    public class RegistroUsuariosController : Controller
    {
        private InventarioDb db = new InventarioDb();

        // GET: RegistroUsuarios
        public ActionResult Index()
        {
            var usuario = db.usuario.Include(r => r.TiposUsuarios);
            return View(usuario.ToList());
        }

        // GET: RegistroUsuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroUsuarios registroUsuarios = db.usuario.Find(id);
            if (registroUsuarios == null)
            {
                return HttpNotFound();
            }
            return View(registroUsuarios);
        }

        // GET: RegistroUsuarios/Create
        public ActionResult Create()
        {
            ViewBag.TiposUsuariosId = new SelectList(db.tipos, "TiposUsuariosId", "Nombre");
            return View();
        }

        // POST: RegistroUsuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsuarioId,TiposUsuariosId,Nombre,Apellido,Clave,Fecha")] RegistroUsuarios registroUsuarios)
        {
            if (ModelState.IsValid)
            {
                db.usuario.Add(registroUsuarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TiposUsuariosId = new SelectList(db.tipos, "TiposUsuariosId", "Nombre", registroUsuarios.TiposUsuariosId);
            return View(registroUsuarios);
        }

        // GET: RegistroUsuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroUsuarios registroUsuarios = db.usuario.Find(id);
            if (registroUsuarios == null)
            {
                return HttpNotFound();
            }
            ViewBag.TiposUsuariosId = new SelectList(db.tipos, "TiposUsuariosId", "Nombre", registroUsuarios.TiposUsuariosId);
            return View(registroUsuarios);
        }

        // POST: RegistroUsuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsuarioId,TiposUsuariosId,Nombre,Apellido,Clave,Fecha")] RegistroUsuarios registroUsuarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registroUsuarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TiposUsuariosId = new SelectList(db.tipos, "TiposUsuariosId", "Nombre", registroUsuarios.TiposUsuariosId);
            return View(registroUsuarios);
        }

        // GET: RegistroUsuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroUsuarios registroUsuarios = db.usuario.Find(id);
            if (registroUsuarios == null)
            {
                return HttpNotFound();
            }
            return View(registroUsuarios);
        }

        // POST: RegistroUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegistroUsuarios registroUsuarios = db.usuario.Find(id);
            db.usuario.Remove(registroUsuarios);
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
