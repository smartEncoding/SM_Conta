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
    public class Cuentas_BancoController : Controller
    {
        private EmpresaContext db = new EmpresaContext();

        // GET: Cuentas_Banco
        public ActionResult Index()
        {
            return View(db.Cuentas_Banco.ToList());
        }

        // GET: Cuentas_Banco/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cuentas_Banco cuentas_Banco = db.Cuentas_Banco.Find(id);
            if (cuentas_Banco == null)
            {
                return HttpNotFound();
            }
            return View(cuentas_Banco);
        }

        // GET: Cuentas_Banco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cuentas_Banco/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Numero,Banco,Cta_ctble,Bco_cta,Activo,Fk_Codigo_Banco")] Cuentas_Banco cuentas_Banco)
        {
            if (ModelState.IsValid)
            {
                db.Cuentas_Banco.Add(cuentas_Banco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cuentas_Banco);
        }

        // GET: Cuentas_Banco/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cuentas_Banco cuentas_Banco = db.Cuentas_Banco.Find(id);
            if (cuentas_Banco == null)
            {
                return HttpNotFound();
            }
            return View(cuentas_Banco);
        }

        // POST: Cuentas_Banco/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Numero,Banco,Cta_ctble,Bco_cta,Activo,Fk_Codigo_Banco")] Cuentas_Banco cuentas_Banco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cuentas_Banco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cuentas_Banco);
        }

        // GET: Cuentas_Banco/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cuentas_Banco cuentas_Banco = db.Cuentas_Banco.Find(id);
            if (cuentas_Banco == null)
            {
                return HttpNotFound();
            }
            return View(cuentas_Banco);
        }

        // POST: Cuentas_Banco/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cuentas_Banco cuentas_Banco = db.Cuentas_Banco.Find(id);
            db.Cuentas_Banco.Remove(cuentas_Banco);
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
