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
    public class DenunciasApiController : ApiController
    {
        // GET: api/DenunciasApi
        [HttpGet]
        public IQueryable<Denuncias> Get()
        {
            RecommendItEntities db = new RecommendItEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return db.Denuncias;

        }

        // GET: api/DenunciasApi/2
        [HttpGet]
        [ResponseType(typeof(Denuncias))]
        public async Task<IHttpActionResult> Get(int id)
        {
            RecommendItEntities db = new RecommendItEntities();
            db.Configuration.ProxyCreationEnabled = false;
            Denuncias denuncia = await db.Denuncias.FindAsync(id);
            if (denuncia == null)
            {
                return NotFound();
            }
            return Ok(denuncia);

        }

        // POST: api/DenunciasApi
        [HttpPost]
        public bool Post(Denuncias denuncia) //Agrego un registro
        {
            RecommendItEntities db = new RecommendItEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Denuncias.Add(denuncia);
            return db.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(Denuncias denuncia) //Modifico un registro
        {
            RecommendItEntities db = new RecommendItEntities();

            db.Configuration.ProxyCreationEnabled = false;
            Denuncias den_antigua = db.Denuncias.FirstOrDefault(x => x.id == denuncia.id);
            den_antigua.id = denuncia.id;
            den_antigua.motivo = denuncia.motivo;
            den_antigua.reputacion_descontada = denuncia.reputacion_descontada;
            return db.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int id) //Elimino un registro
        {
            RecommendItEntities db = new RecommendItEntities();

            db.Configuration.ProxyCreationEnabled = false;
            Denuncias den_encontrada = db.Denuncias.FirstOrDefault(x => x.id == id);
            db.Denuncias.Remove(den_encontrada);
            return db.SaveChanges() > 0;
        }
    }
}
