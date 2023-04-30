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
    public class SucursalesController : Controller
    {
        private EmpresaContext db = new EmpresaContext();

        // GET: Sucursales
        public ActionResult Index()
        {
            return View(db.Sucursales.ToList());
        }

        // GET: Sucursales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sucursal sucursal = db.Sucursales.Find(id);
            if (sucursal == null)
            {
                return HttpNotFound();
            }
            return View(sucursal);
        }

        // GET: Sucursales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sucursales/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nombre,Ciudad,Usa_Exento,Usa_F_Mixt,Imp_2_Cat,Hon_X_Pag,Esp_Petr,Cred_Iva,Deb_Iva,Ret_Iva,Esp_Benc,Cta_Clte,Cta_Pro,caja,Cta_Bol,Cta_I_Clte,Cta_I_Prov,Cta_COMBUS,Cta_I_HONO,Membrete,Domicilio,Cta_P_BOL,Cta_PPM,Cta_DL910,Ch_CARTERA,Cta_EFECT,Ch_X_PAGAR,Cta_ICARNE,Dir_IMPORT,Cta_Fepp,Antic_Cltes,Antic_Prove,Imp_no_Rec,Direccion,Comuna,Activo")] Sucursal sucursal)
        {
            if (ModelState.IsValid)
            {
                db.Sucursales.Add(sucursal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sucursal);
        }

        // GET: Sucursales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sucursal sucursal = db.Sucursales.Find(id);
            if (sucursal == null)
            {
                return HttpNotFound();
            }
            return View(sucursal);
        }

        // POST: Sucursales/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nombre,Ciudad,Usa_Exento,Usa_F_Mixt,Imp_2_Cat,Hon_X_Pag,Esp_Petr,Cred_Iva,Deb_Iva,Ret_Iva,Esp_Benc,Cta_Clte,Cta_Pro,caja,Cta_Bol,Cta_I_Clte,Cta_I_Prov,Cta_COMBUS,Cta_I_HONO,Membrete,Domicilio,Cta_P_BOL,Cta_PPM,Cta_DL910,Ch_CARTERA,Cta_EFECT,Ch_X_PAGAR,Cta_ICARNE,Dir_IMPORT,Cta_Fepp,Antic_Cltes,Antic_Prove,Imp_no_Rec,Direccion,Comuna,Activo")] Sucursal sucursal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sucursal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sucursal);
        }

        // GET: Sucursales/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sucursal sucursal = db.Sucursales.Find(id);
            if (sucursal == null)
            {
                return HttpNotFound();
            }
            return View(sucursal);
        }

        // POST: Sucursales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sucursal sucursal = db.Sucursales.Find(id);
            db.Sucursales.Remove(sucursal);
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
