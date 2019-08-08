using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Roles
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public List<Usuarios> ListaUsuarios = new List<Usuarios>();
    }
}
