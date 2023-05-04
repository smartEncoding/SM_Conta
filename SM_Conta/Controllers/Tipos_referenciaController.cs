using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SM_Conta.Models;

namespace SM_Conta.Controllers
{
    public class Tipos_referenciaController : Controller
    {
        private EmpresaContext db = new EmpresaContext();

        // GET: Tipos_referencia
        public ActionResult Index()
        {
            return View(db.Tipos_referencia.ToList());
        }

        // GET: Tipos_referencia/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipos_referencia tipos_referencia = db.Tipos_referencia.Find(id);
            if (tipos_referencia == null)
            {
                return HttpNotFound();
            }
            return View(tipos_referencia);
        }

        // GET: Tipos_referencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tipos_referencia/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo,Nombre,Activo")] Tipos_referencia tipos_referencia)
        {
            if (ModelState.IsValid)
            {
                db.Tipos_referencia.Add(tipos_referencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipos_referencia);
        }

        // GET: Tipos_referencia/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipos_referencia tipos_referencia = db.Tipos_referencia.Find(id);
            if (tipos_referencia == null)
            {
                return HttpNotFound();
            }
            return View(tipos_referencia);
        }

        // POST: Tipos_referencia/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Codigo,Nombre,Activo")] Tipos_referencia tipos_referencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipos_referencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipos_referencia);
        }

        // GET: Tipos_referencia/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipos_referencia tipos_referencia = db.Tipos_referencia.Find(id);
            if (tipos_referencia == null)
            {
                return HttpNotFound();
            }
            return View(tipos_referencia);
        }

        // POST: Tipos_referencia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tipos_referencia tipos_referencia = db.Tipos_referencia.Find(id);
            db.Tipos_referencia.Remove(tipos_referencia);
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
