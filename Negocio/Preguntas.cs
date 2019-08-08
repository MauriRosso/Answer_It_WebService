using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Preguntas
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string contenido { get; set; }
        public int autor { get; set; }
        public int id_categoria { get; set; }
        public int? visitas { get; set; }
        public int puntaje { get; set; }
        public bool eliminado { get; set; }
        public DateTime? fecha { get; set; }
        public bool denunciado { get; set; }

        public Categorias Categorias { get; set; }
        public List<DenunciasPreguntas> ListaDenunciasPreguntas = new List<DenunciasPreguntas>();
        public List<Respuestas> ListaRespuestas = new List<Respuestas>();
        public List<Tags> ListaTags = new List<Tags>();
        public List<Usuarios> ListaUsuarios = new List<Usuarios>();
    }
}
