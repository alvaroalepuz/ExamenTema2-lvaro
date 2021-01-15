using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Evento
    {
        public Evento()
        {

        }

        public Evento(int eventoId, string nombreLocal, string nombreVisitante, string fecha, double mercado)
        {
            this.eventoId = eventoId;
            this.nombreLocal = nombreLocal;
            this.nombreVisitante = nombreVisitante;
            this.fecha = fecha;
            this.mercado = mercado;
        }



        public int eventoId { get; set; }

        public string nombreLocal { get; set; }

        public string nombreVisitante { get; set; }

        public string fecha { get; set; }

        public double mercado { get; set; }
    }
    //public class EventoDto
    //{
    //    public EventoDto(string nombreLocal, string nombreVisitante, string fecha)
    //    {
    //        this.nombreLocal = nombreLocal;
    //        this.nombreVisitante = nombreVisitante;
    //        this.fecha = fecha;
    //    }




    //    public string nombreLocal { get; set; }

    //    public string nombreVisitante { get; set; }

    //    public string fecha { get; set; }

    //}
}