using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Recomendaciones
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string contenido { get; set; }
        public int id_usuario { get; set; }
        public int id_solicitud_recomendacion { get; set; }
        public int me_gusta { get; set; }
        public bool eliminado { get; set; }
        public DateTime? fecha { get; set; }
    }
}
