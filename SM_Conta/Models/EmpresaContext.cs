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

        public DbSet<Sucursal> Sucursales { get; set; }

        public DbSet<Banco> Bancos { get; set; }

        public System.Data.Entity.DbSet<SM_Conta.Models.Centro_Costo> Centro_Costo { get; set; }

        public System.Data.Entity.DbSet<SM_Conta.Models.Cuentas_Banco> Cuentas_Banco { get; set; }

        public System.Data.Entity.DbSet<SM_Conta.Models.Tasa_Honorario> Tasa_Honorario { get; set; }

        public System.Data.Entity.DbSet<SM_Conta.Models.Tasa_Utm> Tasa_Utm { get; set; }

        public System.Data.Entity.DbSet<SM_Conta.Models.Tasa_PPm> Tasa_PPm { get; set; }

        public System.Data.Entity.DbSet<SM_Conta.Models.Modulos> Modulos { get; set; }

        public System.Data.Entity.DbSet<SM_Conta.Models.Tipos_referencia> Tipos_referencia { get; set; }


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