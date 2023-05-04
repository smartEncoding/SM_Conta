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
    public class Tasa_HonorarioController : Controller
    {
        private EmpresaContext db = new EmpresaContext();

        // GET: Tasa_Honorario
        public ActionResult Index()
        {
            return View(db.Tasa_Honorario.ToList());
        }

        // GET: Tasa_Honorario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tasa_Honorario tasa_Honorario = db.Tasa_Honorario.Find(id);
            if (tasa_Honorario == null)
            {
                return HttpNotFound();
            }
            return View(tasa_Honorario);
        }

        // GET: Tasa_Honorario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tasa_Honorario/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tasa,Anio")] Tasa_Honorario tasa_Honorario)
        {
            if (ModelState.IsValid)
            {
                db.Tasa_Honorario.Add(tasa_Honorario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tasa_Honorario);
        }

        // GET: Tasa_Honorario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tasa_Honorario tasa_Honorario = db.Tasa_Honorario.Find(id);
            if (tasa_Honorario == null)
            {
                return HttpNotFound();
            }
            return View(tasa_Honorario);
        }

        // POST: Tasa_Honorario/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tasa,Anio")] Tasa_Honorario tasa_Honorario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tasa_Honorario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tasa_Honorario);
        }

        // GET: Tasa_Honorario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tasa_Honorario tasa_Honorario = db.Tasa_Honorario.Find(id);
            if (tasa_Honorario == null)
            {
                return HttpNotFound();
            }
            return View(tasa_Honorario);
        }

        // POST: Tasa_Honorario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tasa_Honorario tasa_Honorario = db.Tasa_Honorario.Find(id);
            db.Tasa_Honorario.Remove(tasa_Honorario);
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
