using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class EventosController : ApiController
    {
        // GET: api/Eventos
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET: api/Eventos?NombreELocal=NombreELocal
        //public IEnumerable<Evento> GetNombreFecha(string nombre)
        //{
        //  var repo = new EventoRepository();
        //  List<Evento> eventos = rpeo
        //}

        // GET: api/Eventos/5
        public List<Evento> Get(int id)
        {
            var repo = new EventoRepository();
            List<Evento> e = repo.Retrieve();
            return e;
        }

        // POST: api/Eventos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Eventos/5
        public void Put(int id, [FromBody]Evento e)
        {
            {
                EventoRepository repo = new EventoRepository();
                List<Evento> a = repo.Retrieve2(id);
                repo.Update(e);
            }
        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {
            EventoRepository repo = new EventoRepository();
            Evento a = repo.Retrieve3(id);
            repo.Delete(a);
        }
    }
}
