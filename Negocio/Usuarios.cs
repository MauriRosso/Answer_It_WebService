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
        public string linkedin { get; set; }
        public int reputacion { get; set; }
        public decimal efectividad { get; set; }
        public int nivel { get; set; }
        public string foto { get; set; }
        public int seguidos { get; set; }
        public int seguidores { get; set; }
        public bool eliminado { get; set; }
        public DateTime? fecha_registro { get; set; }
        public string descripcion { get; set; }

        public List<DenunciasPreguntas> ListaDenunciasPreguntas = new List<DenunciasPreguntas>();
        public List<DenunciasRespuestas> ListaDenunciasRespuestas = new List<DenunciasRespuestas>();
        public List<Respuestas> Respuestas { get; set; }
        public  Roles Roles { get; set; }
        public List<Medallas> ListaMedallas = new List<Medallas>();
        public List<Privilegios> ListaPrivilegios = new List<Privilegios>();
        public List<Preguntas> ListaPreguntas = new List<Preguntas>();
    }
}
