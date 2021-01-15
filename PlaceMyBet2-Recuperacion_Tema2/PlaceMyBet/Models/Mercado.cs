using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Mercado
    {

        public Mercado(int mercadoId, double mercado, double cuotaOver, double cuotaUnder, double dineroOver, double dineroUnder)
        {
            this.mercadoId = mercadoId;
            this.mercado = mercado;
            this.cuotaOver = cuotaOver;
            this.cuotaUnder = cuotaUnder;
            this.dineroOver = dineroOver;
            this.dineroUnder = dineroUnder;

        }

        public int mercadoId { get; set; }

        public double mercado { get; set; }

        public double cuotaOver { get; set; }

        public double cuotaUnder { get; set; }

        public double dineroOver { get; set; }

        public double dineroUnder { get; set; }

        public List<Evento> eventos2 { get; set; }

        public List<Usuario> usuarios2 { get; set; }




    }





}