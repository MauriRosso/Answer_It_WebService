using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DenunciasSolicitudValoraciones
    {
        public int id { get; set; }
        public int id_solicitud_valoracion { get; set; }
        public int id_usuario { get; set; }
        public int motivo { get; set; }
        public DateTime? fecha_denuncia { get; set; }
        public string descripcion { get; set; }
    }
}
