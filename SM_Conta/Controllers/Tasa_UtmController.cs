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
    public class Tasa_UtmController : Controller
    {
        private EmpresaContext db = new EmpresaContext();

        // GET: Tasa_Utm
        public ActionResult Index()
        {
            return View(db.Tasa_Utm.ToList());
        }

        // GET: Tasa_Utm/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tasa_Utm tasa_Utm = db.Tasa_Utm.Find(id);
            if (tasa_Utm == null)
            {
                return HttpNotFound();
            }
            return View(tasa_Utm);
        }

        // GET: Tasa_Utm/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tasa_Utm/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Anio,Mes01,Mes02,Mes03,Mes04,Mes05,Mes06,Mes07,Mes08,Mes09,Mes10,Mes11,Mes12")] Tasa_Utm tasa_Utm)
        {
            if (ModelState.IsValid)
            {
                db.Tasa_Utm.Add(tasa_Utm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tasa_Utm);
        }

        // GET: Tasa_Utm/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tasa_Utm tasa_Utm = db.Tasa_Utm.Find(id);
            if (tasa_Utm == null)
            {
                return HttpNotFound();
            }
            return View(tasa_Utm);
        }

        // POST: Tasa_Utm/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Anio,Mes01,Mes02,Mes03,Mes04,Mes05,Mes06,Mes07,Mes08,Mes09,Mes10,Mes11,Mes12")] Tasa_Utm tasa_Utm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tasa_Utm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tasa_Utm);
        }

        // GET: Tasa_Utm/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tasa_Utm tasa_Utm = db.Tasa_Utm.Find(id);
            if (tasa_Utm == null)
            {
                return HttpNotFound();
            }
            return View(tasa_Utm);
        }

        // POST: Tasa_Utm/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tasa_Utm tasa_Utm = db.Tasa_Utm.Find(id);
            db.Tasa_Utm.Remove(tasa_Utm);
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
