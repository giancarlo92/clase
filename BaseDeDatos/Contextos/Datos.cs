using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BaseDeDatos.Modelos;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BaseDeDatos.Contextos
{
    public class Datos : DbContext
    {
        public Datos() : base("NuevaBD") { }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Telefono> Telefono { get; set; }
        public DbSet<AplicacionesMoviles> Aplicacion { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
