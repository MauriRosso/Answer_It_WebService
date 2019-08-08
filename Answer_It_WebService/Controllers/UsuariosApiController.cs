using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Datos;

namespace Answer_It_WebService.Controllers
{
    public class UsuariosApiController : ApiController
    {
        // GET: api/UsuariosApi
        public IQueryable<Usuarios> Get()
        {
            AnswerItDBEntities db = new AnswerItDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return db.Usuarios;

        }

        //public Usuarios GetUsuariosPorNombre(string nombre_usuario, string contrasena)
        //{
        //    AnswerItDBEntities db = new AnswerItDBEntities();
        //    db.Configuration.ProxyCreationEnabled = false;
        //    IQueryable<Usuarios> usuarios = Get();
        //    foreach (var item in usuarios)
        //    {
        //        if (nombre_usuario == item.nombre_usuario)
        //        {
        //            if (contrasena == item.contrasena)
        //            {
        //                return item;
        //            }
        //        }
        //    }
        //    return null;

        //}

        // GET: api/UsuariosApi/2
        [ResponseType(typeof(Usuarios))]
        public async Task<IHttpActionResult> GetUsuariosPorId(int id)
        {
            AnswerItDBEntities db = new AnswerItDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            Usuarios usuario = await db.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);

        }

        // POST: api/UsuariosApi
        public HttpResponseMessage Post([FromBody]Usuarios usuario)
        {
            AnswerItDBEntities db = new AnswerItDBEntities();
            try
            {
                db.Configuration.ProxyCreationEnabled = false;
                db.Usuarios.Add(usuario);
                db.SaveChanges();

                var message = Request.CreateResponse(HttpStatusCode.Created, usuario);
                message.Headers.Location = new Uri(Request.RequestUri + usuario.id.ToString());
                return message;

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // PUT: api/UsuariosApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UsuariosApi/5
        public void Delete(int id)
        {
        }
    }
}
