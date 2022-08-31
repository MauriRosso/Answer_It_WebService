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
//    public class DenunciasRespuestasApiController : ApiController
//    {
//        // GET: api/DenunciasRespuestasApi
//        [HttpGet]
//        public IQueryable<DenunciasRespuestas> Get()
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();
//            db.Configuration.ProxyCreationEnabled = false;
//            return db.DenunciasRespuestas;

//        }

//        // GET: api/DenunciasRespuestas/2
//        [HttpGet]
//        [ResponseType(typeof(DenunciasRespuestas))]
//        public async Task<IHttpActionResult> Get(int id)
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();
//            db.Configuration.ProxyCreationEnabled = false;
//            DenunciasRespuestas denuncia = await db.DenunciasRespuestas.FindAsync(id);
//            if (denuncia == null)
//            {
//                return NotFound();
//            }
//            return Ok(denuncia);

//        }

//        // POST: api/DenunciasRespuestas
//        [HttpPost]
//        public bool Post(DenunciasRespuestas denuncia) //Agrego un registro
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();
//            db.Configuration.ProxyCreationEnabled = false;
//            db.DenunciasRespuestas.Add(denuncia);
//            return db.SaveChanges() > 0;
//        }

//        [HttpPut]
//        public bool Put(DenunciasRespuestas denuncia) //Modifico un registro
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();

//            db.Configuration.ProxyCreationEnabled = false;
//            DenunciasRespuestas den_antigua = db.DenunciasRespuestas.FirstOrDefault(x => x.id == denuncia.id);

//            den_antigua.id = denuncia.id;
//            den_antigua.id_respuesta = denuncia.id_respuesta;
//            den_antigua.motivo = denuncia.motivo;
//            den_antigua.fecha_denuncia = denuncia.fecha_denuncia;
//            den_antigua.descripcion = denuncia.descripcion;
//            den_antigua.autor = denuncia.autor;
//            den_antigua.Denuncias = denuncia.Denuncias;
//            den_antigua.Respuestas = denuncia.Respuestas;
//            den_antigua.Usuarios = denuncia.Usuarios;
//            return db.SaveChanges() > 0;
//        }

//        [HttpDelete]
//        public bool Delete(int id) //Elimino un registro
//        {
//            AnswerItDBEntities db = new AnswerItDBEntities();

//            db.Configuration.ProxyCreationEnabled = false;
//            DenunciasRespuestas den_encontrada = db.DenunciasRespuestas.FirstOrDefault(x => x.id == id);
//            db.DenunciasRespuestas.Remove(den_encontrada);
//            return db.SaveChanges() > 0;
//        }
//    }
//}
