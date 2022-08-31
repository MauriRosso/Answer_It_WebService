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
        [HttpGet]
        public IQueryable<Usuarios> Get()
        {
            RecommendItEntities db = new RecommendItEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return db.Usuarios;

        }

        // GET: api/UsuariosApi/2
        [HttpGet]
        [ResponseType(typeof(Usuarios))]
        public async Task<IHttpActionResult> Get(int id)
        {
            RecommendItEntities db = new RecommendItEntities();
            db.Configuration.ProxyCreationEnabled = false;
            Usuarios usuario = await db.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);

        }

        // POST: api/UsuariosApi
        [HttpPost]
        public bool Post(Usuarios usuario) //Agrego un registro
        {
            RecommendItEntities db = new RecommendItEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Usuarios.Add(usuario);
            return db.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(Usuarios usuario) //Modifico un registro
        {
            RecommendItEntities db = new RecommendItEntities();

            db.Configuration.ProxyCreationEnabled = false;
            Usuarios usu_antiguo = db.Usuarios.FirstOrDefault(x => x.id == usuario.id);

            usu_antiguo.id = usuario.id;
            usu_antiguo.email = usuario.email;
            usu_antiguo.nombre_usuario = usuario.nombre_usuario;
            usu_antiguo.apellido = usuario.apellido;
            usu_antiguo.nombre = usuario.nombre;
            usu_antiguo.id_rol = usuario.id_rol;
            usu_antiguo.pais = usuario.pais;
            usu_antiguo.localidad = usuario.localidad;
            usu_antiguo.reputacion = usuario.reputacion;
            usu_antiguo.efectividad = usuario.efectividad;
            usu_antiguo.nivel = usuario.nivel;
            usu_antiguo.foto = usuario.foto;
            usu_antiguo.eliminado = usuario.eliminado;
            usu_antiguo.fecha_registro = usuario.fecha_registro;
            usu_antiguo.descripcion = usuario.descripcion;
            usu_antiguo.es_primera_vez = usuario.es_primera_vez;
            return db.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int id) //Elimino un registro
        {
            RecommendItEntities db = new RecommendItEntities();

            db.Configuration.ProxyCreationEnabled = false;
            Usuarios usu_encontrado = db.Usuarios.FirstOrDefault(x => x.id == id);
            db.Usuarios.Remove(usu_encontrado);
            return db.SaveChanges() > 0; 
        }
    }
}
