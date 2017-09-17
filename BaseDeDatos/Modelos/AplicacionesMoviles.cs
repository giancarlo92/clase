using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos.Modelos
{
    public class AplicacionesMoviles : BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<Telefono> Telefonos { get; set; }
        public AplicacionesMoviles() : base()
        {
            this.Telefonos = new HashSet<Telefono>();
        }
    }
}
