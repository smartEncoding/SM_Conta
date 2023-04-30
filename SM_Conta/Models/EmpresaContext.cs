using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace SM_Conta.Models
{
    public class EmpresaContext : DbContext
    {
        public EmpresaContext() : base("EmpresaConnection")
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public DbSet<PlanCuenta> PlanCuentas { get; set; }

        public System.Data.Entity.DbSet<SM_Conta.Models.Sucursal> Sucursales { get; set; }


        /*
         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<PlanCuenta>().HasData(
             new PlanCuenta
             {
                 Cuenta = 1000000,
                 Nombre = "Activo",
                 Pertence = 0,
                 Nivel = 0,
                 Tipo = 0
             });
         }
        */
    }
}