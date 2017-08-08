﻿using System;
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
    public class RegistroSparesController : Controller
    {
        private InventarioDb db = new InventarioDb();

        // GET: RegistroSpares
        public ActionResult Index()
        {
            return View(db.spare.ToList());
        }

        // GET: RegistroSpares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroSpares registroSpares = db.spare.Find(id);
            if (registroSpares == null)
            {
                return HttpNotFound();
            }
            return View(registroSpares);
        }

        // GET: RegistroSpares/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistroSpares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SpareId,AlmacenId,Nombre,NumeroParte,SerialNumero,Ubicacion,Fecha")] RegistroSpares registroSpares)
        {
            if (ModelState.IsValid)
            {
                db.spare.Add(registroSpares);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registroSpares);
        }

        // GET: RegistroSpares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroSpares registroSpares = db.spare.Find(id);
            if (registroSpares == null)
            {
                return HttpNotFound();
            }
            return View(registroSpares);
        }

        // POST: RegistroSpares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( RegistroSpares registroSpares)
        {
            if (ModelState.IsValid)
            {
                SparesBLL.Guardar(registroSpares);
                return RedirectToAction("Index");
            }
            return View(registroSpares);
        }

        // GET: RegistroSpares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroSpares registroSpares = db.spare.Find(id);
            if (registroSpares == null)
            {
                return HttpNotFound();
            }
            return View(registroSpares);
        }

        // POST: RegistroSpares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegistroSpares registroSpares = db.spare.Find(id);
            db.spare.Remove(registroSpares);
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
