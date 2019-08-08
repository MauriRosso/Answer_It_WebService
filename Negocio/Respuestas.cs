using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Respuestas
    {
        public int id { get; set; }
        public string contenido { get; set; }
        public int autor { get; set; }
        public int id_pregunta { get; set; }
        public int puntaje { get; set; }
        public bool eliminado { get; set; }
        public string imagen { get; set; }
        public DateTime? fecha { get; set; }
        public bool denunciado { get; set; }

        public List<DenunciasRespuestas> ListaDenunciasRespuestas = new List<DenunciasRespuestas>();
        public Preguntas Preguntas { get; set; }
        public Usuarios Usuarios { get; set; }

        public List<Tags> ListaTags = new List<Tags>();
    }
}
