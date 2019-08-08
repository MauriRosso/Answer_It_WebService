using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Privilegios
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int reputacion_necesaria { get; set; }
        public string descripcion { get; set; }
        public string tipo_privilegio { get; set; }

        public List<Usuarios> ListaUsuarios = new List<Usuarios>();
    }
}
