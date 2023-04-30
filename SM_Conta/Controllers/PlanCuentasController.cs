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
    public class PlanCuentasController : Controller
    {
        private EmpresaContext db = new EmpresaContext();

        // GET: PlanCuentas
        public ActionResult Index()
        {
            return View(db.PlanCuentas.OrderBy(c=>c.Cuenta).ToList());
        }

        // GET: PlanCuentas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanCuenta planCuenta = db.PlanCuentas.Find(id);
            if (planCuenta == null)
            {
                return HttpNotFound();
            }
            return View(planCuenta);
        }

        // GET: PlanCuentas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlanCuentas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_plan_cta,Anio,Cuenta,Nombre,Pertence,Principal,Analisis,Capital,Cons_Banc,T_analisi,Est_Resu,Es_Pago,Nivel,Tipo,CapPropio,ActFijo,Cp_ActNorm,Cp_Into,Cp_Complem,Cp_PasExig")] PlanCuenta planCuenta)
        {
            if (ModelState.IsValid)
            {

                planCuenta = ObtienePadre(planCuenta);
                db.PlanCuentas.Add(planCuenta);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    if (ex.InnerException != null &&
                        ex.InnerException.InnerException != null &&
                        ex.InnerException.InnerException.Message.Contains("Indice_PlanCta_Cuenta"))
                    {
                        ModelState.AddModelError(string.Empty, "Esta Cuenta ya existe, intente otro");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, ex.Message);
                    }
                    return View(planCuenta);
                }
                return RedirectToAction("Index");
            }

            return View(planCuenta);
        }

        // GET: PlanCuentas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanCuenta planCuenta = db.PlanCuentas.Find(id);
            if (planCuenta == null)
            {
                return HttpNotFound();
            }
            return View(planCuenta);
        }

        // POST: PlanCuentas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_plan_cta,Anio,Cuenta,Nombre,Pertence,Principal,Analisis,Capital,Cons_Banc,T_analisi,Est_Resu,Es_Pago,Nivel,Tipo,CapPropio,ActFijo,Cp_ActNorm,Cp_Into,Cp_Complem,Cp_PasExig")] PlanCuenta planCuenta)
        {
            if (ModelState.IsValid)
            {
                //planCuenta = ObtienePadre(planCuenta);
                db.Entry(planCuenta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(planCuenta);
        }

        // GET: PlanCuentas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanCuenta planCuenta = db.PlanCuentas.Find(id);
            if (planCuenta == null)
            {
                return HttpNotFound();
            }
            return View(planCuenta);
        }

        // POST: PlanCuentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlanCuenta planCuenta = db.PlanCuentas.Find(id);
            db.PlanCuentas.Remove(planCuenta);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public PlanCuenta ObtienePadre(PlanCuenta planCuenta)
        {
            string Cuenta;
            string Aux;
            int Nivel;

            Cuenta = planCuenta.Cuenta.ToString();
            string Nivel0= Cuenta.Substring(0, 1);                             
            string Nivel1= Cuenta.Substring(1, 1);
            string Nivel2= Cuenta.Substring(2, 2);
            string Nivel3= Cuenta.Substring(4, 3);
            Aux = "0";
            if (Int32.Parse(Nivel1) != 0)
            {
                Aux = Nivel0 + "000";                                      // 1000
            }

            if (Int32.Parse(Nivel2) != 0)
                Aux = Nivel0 + Nivel1 + "00";                                      // 1100

            if (Int32.Parse(Nivel3) != 0)
                Aux = Nivel0 + Nivel1 + Nivel2;                                      // 1100

            Aux = Aux + "000";
            Nivel = 4;
            var Principal = false;
            if (Int32.Parse(Nivel3) == 0)
            {
                if (Int32.Parse(Nivel2) == 0)
                {
                    if (Int32.Parse(Nivel1) == 0)
                    {
                        Nivel = 1;
                    }
                    else
                    {
                        Nivel = 0;
                        Principal = true;
                    }
                }
                else
                { 
                    Nivel = 2; 
                }
            }
            else
            { Nivel = 3;}
            
            planCuenta.Nivel = Nivel;
            planCuenta.Principal = Principal;
            planCuenta.Tipo = int.Parse(Nivel0);

           
            int per;
            per = int.Parse(Aux);
            
            if (!String.IsNullOrEmpty(Aux))
            {
                var per1 = from c in db.PlanCuentas where c.Cuenta == per select c.Id_plan_cta;
                if (per1 != null && per1.Count()>0)
                    per = per1.Single();
            }
            return planCuenta;// registros.Select( Select("Id_plan_cta");



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
