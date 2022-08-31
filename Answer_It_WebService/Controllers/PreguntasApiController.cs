//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;
//using System.Web.Http;
//using System.Web.Http.Description;
//using Datos;

//namespace Answer_It_WebService.Controllers
//{
//    public class PreguntasApiController : ApiController
//    {
//        // GET: api/PreguntasApi
//        [HttpGet]
//        public IQueryable<Preguntas> Get()
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();
//            db.Configuration.ProxyCreationEnabled = false;
//            return db.Preguntas;

//        }

//        // GET: api/PreguntasApi/2
//        [HttpGet]
//        [ResponseType(typeof(Preguntas))]
//        public async Task<IHttpActionResult> Get(int id)
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();
//            db.Configuration.ProxyCreationEnabled = false;
//            Preguntas pregunta = await db.Preguntas.FindAsync(id);
//            if (pregunta == null)
//            {
//                return NotFound();
//            }
//            return Ok(pregunta);

//        }

//        // POST: api/PreguntasApi
//        [HttpPost]
//        public bool Post(Preguntas pregunta) //Agrego un registro
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();
//            db.Configuration.ProxyCreationEnabled = false;
//            db.Preguntas.Add(pregunta);
//            return db.SaveChanges() > 0;
//        }

//        [HttpPut]
//        public bool Put(Preguntas pregunta) //Modifico un registro
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();

//            db.Configuration.ProxyCreationEnabled = false;
//            Preguntas preg_antigua = db.Preguntas.FirstOrDefault(x => x.id == pregunta.id);

//            preg_antigua.autor = pregunta.autor;
//            preg_antigua.contenido = pregunta.contenido;
//            preg_antigua.denunciado = pregunta.denunciado;
//            preg_antigua.eliminado = pregunta.eliminado;
//            preg_antigua.fecha = pregunta.fecha;
//            preg_antigua.id = pregunta.id;
//            preg_antigua.id_categoria = pregunta.id_categoria;
//            preg_antigua.puntaje = pregunta.puntaje;
//            preg_antigua.titulo = pregunta.titulo;
//            preg_antigua.visitas = pregunta.visitas;
//            preg_antigua.cant_votos = pregunta.cant_votos;
//            preg_antigua.Usuarios = pregunta.Usuarios;
//            preg_antigua.Tags = pregunta.Tags;
//            preg_antigua.Respuestas = pregunta.Respuestas;
//            preg_antigua.DenunciasPreguntas = pregunta.DenunciasPreguntas;
//            preg_antigua.Categorias = pregunta.Categorias;
//            return db.SaveChanges() > 0;
//        }

//        [HttpDelete]
//        public bool Delete(int id) //Elimino un registro
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();

//            db.Configuration.ProxyCreationEnabled = false;
//            Preguntas preg_encontrada = db.Preguntas.FirstOrDefault(x => x.id == id);
//            db.Preguntas.Remove(preg_encontrada);
//            return db.SaveChanges() > 0;
//        }
//    }
//}