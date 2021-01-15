using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class ApuestasController : ApiController
    {
        // GET: api/Apuestas
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Apuestas/5
        //public List<Apuesta> Get(int id)//ApuestaDto3
        //{
        //    var repo = new ApuestaRepository();
        //    List<Apuesta> a = repo.Retrieve(id);//Filtrar3
        //    return a;
        //}

        // ////EXAMEN//////////////////////////////////////////////////////////////////////////
        // GET: api/Apuestas
        public List<ApuestaDto> Get(string NombreEquipo)
        {
            var repo = new ApuestaRepository();
            List<ApuestaDto> m = repo.Retrieve2(NombreEquipo);
            return m;
        }
        // //ACABA EXAMEN/////////////////////////////////////////////////////////////////////////////////////////////7

        // POST: api/Apuestas
        //[Authorize]
        public void Post([FromBody]Apuesta apuesta)
        {
            var repo = new ApuestaRepository();
            repo.Save(apuesta); 
        }

        // PUT: api/Apuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuestas/5
        public void Delete(int id)
        {
        }
    }
}
