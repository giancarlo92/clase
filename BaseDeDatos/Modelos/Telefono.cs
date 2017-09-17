using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos.Modelos
{
    public class Telefono : BaseEntity
    {
        [Required]
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int numeroTelefonico { get; set; }
        public DateTime? FechaDeLanzamiento { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public ICollection<AplicacionesMoviles> App { get; set; }
        public Telefono() : base()
        {
            this.App = new HashSet<AplicacionesMoviles>();
        }
    }
}
