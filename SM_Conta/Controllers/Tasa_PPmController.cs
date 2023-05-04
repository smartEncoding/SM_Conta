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
    public class Tasa_PPmController : Controller
    {
        private EmpresaContext db = new EmpresaContext();

        // GET: Tasa_PPm
        public ActionResult Index()
        {
            return View(db.Tasa_PPm.ToList());
        }

        // GET: Tasa_PPm/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tasa_PPm tasa_PPm = db.Tasa_PPm.Find(id);
            if (tasa_PPm == null)
            {
                return HttpNotFound();
            }
            return View(tasa_PPm);
        }

        // GET: Tasa_PPm/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tasa_PPm/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Anio,m1,m2,m3,m4,m5,m6,m7,m8,m9,m10,m11,m12,p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12")] Tasa_PPm tasa_PPm)
        {
            if (ModelState.IsValid)
            {
                db.Tasa_PPm.Add(tasa_PPm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tasa_PPm);
        }

        // GET: Tasa_PPm/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tasa_PPm tasa_PPm = db.Tasa_PPm.Find(id);
            if (tasa_PPm == null)
            {
                return HttpNotFound();
            }
            return View(tasa_PPm);
        }

        // POST: Tasa_PPm/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Anio,m1,m2,m3,m4,m5,m6,m7,m8,m9,m10,m11,m12,p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12")] Tasa_PPm tasa_PPm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tasa_PPm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tasa_PPm);
        }

        // GET: Tasa_PPm/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tasa_PPm tasa_PPm = db.Tasa_PPm.Find(id);
            if (tasa_PPm == null)
            {
                return HttpNotFound();
            }
            return View(tasa_PPm);
        }

        // POST: Tasa_PPm/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tasa_PPm tasa_PPm = db.Tasa_PPm.Find(id);
            db.Tasa_PPm.Remove(tasa_PPm);
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
