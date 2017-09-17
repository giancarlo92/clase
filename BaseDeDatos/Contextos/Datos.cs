using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BaseDeDatos.Modelos;

namespace BaseDeDatos.Contextos
{
    public class Datos : DbContext
    {
        public Datos() : base("NuevaBD") { }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
