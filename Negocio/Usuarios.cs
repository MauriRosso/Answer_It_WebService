using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Usuarios
    {
        public int id { get; set; }
        public string email { get; set; }
        public string nombre_usuario { get; set; }
        public string contrasena { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int id_rol { get; set; }
        public string pais { get; set; }
        public string localidad { get; set; }
        public int reputacion { get; set; }
        public decimal efectividad { get; set; }
        public int nivel { get; set; }
        public string foto { get; set; }
        public bool eliminado { get; set; }
        public DateTime? fecha_registro { get; set; }
        public string descripcion { get; set; }
        public bool? es_primera_vez { get; set; }
    }
}
