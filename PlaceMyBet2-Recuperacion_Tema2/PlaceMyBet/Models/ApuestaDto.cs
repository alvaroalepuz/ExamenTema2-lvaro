using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class ApuestaDto
    {
        ///EXAMEN///
            public ApuestaDto(string apuestaId, string tipo, double dinero, int mercadoId, string nombreLocal,string nombreVisitante)
            {
                this.apuestaId = apuestaId;
                this.tipo = tipo;
                this.dinero = dinero;
                this.mercadoId = mercadoId;
                this.nombreLocal = nombreLocal;
                this.nombreVisitante = nombreVisitante;
        }

        public string apuestaId { get; set; }

        public string tipo { get; set; }

        public double dinero { get; set; }

        public int mercadoId { get; set; }

        public string nombreLocal { get; set; }

        public string nombreVisitante { get; set; }



    }
}