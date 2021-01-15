using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class CasaApuestasController : ApiController
    {
        // GET: api/CasaApuestas
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CasaApuestas/5
        //public CasaApuestas Get(int id)
        //{
        //    //var
        //    var repo = new CasaApuestasRepository();
        //    CasaApuestas c = repo.Retrieve();
        //    return c;
        //}

        // POST: api/CasaApuestas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CasaApuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CasaApuestas/5
        public void Delete(int id)
        {
        }
    }
}
