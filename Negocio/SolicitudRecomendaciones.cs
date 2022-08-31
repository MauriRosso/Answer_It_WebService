using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class SolicitudRecomendaciones
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string leyenda { get; set; }
        public int id_usuario { get; set; }
        public int? visitas { get; set; }
        public bool eliminado { get; set; }
        public DateTime? fecha { get; set; }
        public int reputacion_otorgada { get; set; }
        public bool sin_skill { get; set; }
        public bool skill_prisa { get; set; }
        public bool skill_destacado { get; set; }
        public int? nivel_requerido { get; set; }
    }
}
