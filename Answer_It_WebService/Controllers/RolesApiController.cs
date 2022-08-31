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
    public class RolesApiController : ApiController
    {
        // GET: api/RolesApi
        [HttpGet]
        public IQueryable<Roles> Get()
        {
            RecommendItEntities db = new RecommendItEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return db.Roles;

        }

        // GET: api/RolesApi/2
        [HttpGet]
        [ResponseType(typeof(Roles))]
        public async Task<IHttpActionResult> Get(int id)
        {
            RecommendItEntities db = new RecommendItEntities();
            db.Configuration.ProxyCreationEnabled = false;
            Roles rol = await db.Roles.FindAsync(id);
            if (rol == null)
            {
                return NotFound();
            }
            return Ok(rol);

        }

        // POST: api/RolesApi
        [HttpPost]
        public bool Post(Roles rol) //Agrego un registro
        {
            RecommendItEntities db = new RecommendItEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Roles.Add(rol);
            return db.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(Roles rol) //Modifico un registro
        {
            RecommendItEntities db = new RecommendItEntities();

            db.Configuration.ProxyCreationEnabled = false;
            Roles rol_antiguo = db.Roles.FirstOrDefault(x => x.id == rol.id);
            rol_antiguo.id = rol.id;
            rol_antiguo.nombre = rol.nombre;
            rol_antiguo.Usuarios = rol.Usuarios;
            return db.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int id) //Elimino un registro
        {
            RecommendItEntities db = new RecommendItEntities();

            db.Configuration.ProxyCreationEnabled = false;
            Roles rol_encontrado = db.Roles.FirstOrDefault(x => x.id == id);
            db.Roles.Remove(rol_encontrado);
            return db.SaveChanges() > 0;
        }
    }
}
