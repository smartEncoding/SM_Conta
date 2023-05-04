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
    public class Centro_CostoController : Controller
    {
        private EmpresaContext db = new EmpresaContext();

        // GET: Centro_Costo
        public ActionResult Index()
        {
            return View(db.Centro_Costo.ToList());
        }

        // GET: Centro_Costo/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Centro_Costo centro_Costo = db.Centro_Costo.Find(id);
            if (centro_Costo == null)
            {
                return HttpNotFound();
            }
            return View(centro_Costo);
        }

        // GET: Centro_Costo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Centro_Costo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Activo")] Centro_Costo centro_Costo)
        {
            if (ModelState.IsValid)
            {
                db.Centro_Costo.Add(centro_Costo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(centro_Costo);
        }

        // GET: Centro_Costo/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Centro_Costo centro_Costo = db.Centro_Costo.Find(id);
            if (centro_Costo == null)
            {
                return HttpNotFound();
            }
            return View(centro_Costo);
        }

        // POST: Centro_Costo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Activo")] Centro_Costo centro_Costo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(centro_Costo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(centro_Costo);
        }

        // GET: Centro_Costo/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Centro_Costo centro_Costo = db.Centro_Costo.Find(id);
            if (centro_Costo == null)
            {
                return HttpNotFound();
            }
            return View(centro_Costo);
        }

        // POST: Centro_Costo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Centro_Costo centro_Costo = db.Centro_Costo.Find(id);
            db.Centro_Costo.Remove(centro_Costo);
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
