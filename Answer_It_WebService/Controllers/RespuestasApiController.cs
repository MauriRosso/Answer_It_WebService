//using Datos;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;
//using System.Web.Http;
//using System.Web.Http.Description;

//namespace Answer_It_WebService.Controllers
//{
//    public class RespuestasApiController : ApiController
//    {
//        // GET: api/RespuestasApi
//        [HttpGet]
//        public IQueryable<Respuestas> Get()
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();
//            db.Configuration.ProxyCreationEnabled = false;
//            return db.Respuestas;

//        }

//        // GET: api/RespuestasApi/2
//        [HttpGet]
//        [ResponseType(typeof(Respuestas))]
//        public async Task<IHttpActionResult> Get(int id)
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();
//            db.Configuration.ProxyCreationEnabled = false;
//            Respuestas respuesta = await db.Respuestas.FindAsync(id);
//            if (respuesta == null)
//            {
//                return NotFound();
//            }
//            return Ok(respuesta);

//        }

//        // POST: api/RespuestasApi
//        [HttpPost]
//        public bool Post(Respuestas respuesta) //Agrego un registro
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();
//            db.Configuration.ProxyCreationEnabled = false;
//            db.Respuestas.Add(respuesta);
//            return db.SaveChanges() > 0;
//        }

//        [HttpPut]
//        public bool Put(Respuestas respuesta) //Modifico un registro
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();

//            db.Configuration.ProxyCreationEnabled = false;
//            Respuestas res_antigua = db.Respuestas.FirstOrDefault(x => x.id == respuesta.id);

//            res_antigua.id = respuesta.id;
//            res_antigua.id_pregunta = respuesta.id_pregunta;
//            res_antigua.imagen = respuesta.imagen;
//            res_antigua.puntaje = respuesta.puntaje;
//            res_antigua.fecha = respuesta.fecha;
//            res_antigua.eliminado = respuesta.eliminado;
//            res_antigua.denunciado = respuesta.denunciado;
//            res_antigua.contenido = respuesta.contenido;
//            res_antigua.autor = respuesta.autor;
//            res_antigua.cant_votos = respuesta.cant_votos;
//            res_antigua.Usuarios = respuesta.Usuarios;
//            res_antigua.Tags = respuesta.Tags;
//            res_antigua.Preguntas = respuesta.Preguntas;
//            res_antigua.DenunciasRespuestas = respuesta.DenunciasRespuestas;
//            res_antigua.Usuarios1 = respuesta.Usuarios1; //Tabla intermedia UsuariosRespuestas (cada usuario aparece en muchas respuestas viendola de este lado)
//            return db.SaveChanges() > 0;
//        }

//        [HttpDelete]
//        public bool Delete(int id) //Elimino un registro
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();

//            db.Configuration.ProxyCreationEnabled = false;
//            Respuestas res_encontrada = db.Respuestas.FirstOrDefault(x => x.id == id);
//            db.Respuestas.Remove(res_encontrada);
//            return db.SaveChanges() > 0;
//        }
//    }
//}