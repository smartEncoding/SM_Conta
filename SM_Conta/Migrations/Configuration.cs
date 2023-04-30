namespace SM_Conta.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SM_Conta.Models.EmpresaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SM_Conta.Models.EmpresaContext";
        }

        protected override void Seed(SM_Conta.Models.EmpresaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.PlanCuentas.AddOrUpdate(
                c => c.Cuenta,
                new Models.PlanCuenta
                {
                    Cuenta = 1000000,
                    Nombre = "ACTIVO",
                    Pertence = 0,
                    Principal = true,
                    Nivel = 0,
                    Tipo = 1
                },
                new Models.PlanCuenta
                {
                    Cuenta = 2000000,
                    Nombre = "PASIVO",
                    Pertence = 0,
                    Principal = true,
                    Nivel = 0,
                    Tipo = 2
                },
                new Models.PlanCuenta
                {
                    Cuenta = 3000000,
                    Nombre = "PERDIDA",
                    Pertence = 0,
                    Principal = true,
                    Nivel = 0,
                    Tipo = 3
                },
                new Models.PlanCuenta
                {
                    Cuenta = 4000000,
                    Nombre = "GANANCIA",
                    Pertence = 0,
                    Principal = true,
                    Nivel = 0,
                    Tipo = 4
                }
                );
            context.Sucursales.AddOrUpdate(
                s => s.Codigo,
                new Models.Sucursal
                {
                    Codigo = 0,
                    Nombre = "Casa Matriz",
                    Ciudad = " ",
                    Membrete="Casa Matriz",
                    Direccion=" ",
                    Domicilio=" ",
                    Comuna=" ",
                    Activo=true
                }
                ) ;
        }
    }
}
