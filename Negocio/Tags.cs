using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Tags
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public List<Preguntas> ListaPreguntas = new List<Preguntas>();
        public List<Respuestas> ListaRespuestas = new List<Respuestas>();
    }
}
