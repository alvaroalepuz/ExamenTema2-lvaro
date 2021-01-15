using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PlaceMyBet.Models
{
    public class Apuesta
    {
        public Apuesta()
        {

        }
        public Apuesta(string apuestaId, string tipo, double dinero, int mercadoId)
        {
            this.apuestaId = apuestaId;
            this.tipo = tipo;
            this.dinero = dinero;
            this.mercadoId = mercadoId;

        }

        public string apuestaId { get; set; }

        public string tipo { get; set; }

        public double dinero { get; set; }

        public int mercadoId { get; set; }



        public Mercado mercados2 { get; set; }
    }
    //public class ApuestaDto
    //{
    //    public ApuestaDto(string tipo, double dinero, double cuotaOver, double cuotaUnder, string correo, string fecha)
    //    {
    //        this.tipo = tipo;
    //        this.dinero = dinero;
    //        this.cuotaOver = cuotaOver;
    //        this.cuotaUnder = cuotaUnder;
    //        this.correo = correo;
    //        this.fecha = fecha;
    //    }

    //    public string tipo { get; set; }
    //    public double dinero { get; set; }
    //    public double cuotaOver { get; set; }
    //    public double cuotaUnder { get; set; }
    //    public string correo { get; set; }
    //    public string fecha { get; set; }
    //}
    public class ApuestaDto2
    {
        public ApuestaDto2(int idEvento, string tipo, double cuotaOver, double cuotaUnder, double dinero)
        {
            this.idEvento = idEvento;
            this.tipo = tipo;
            this.cuotaOver = cuotaOver;
            this.cuotaUnder = cuotaUnder;
            this.dinero = dinero;
        }

        public int idEvento { get; set; }

        public string tipo { get; set; }

        public double cuotaOver { get; set; }

        public double cuotaUnder { get; set; }

        public double dinero { get; set; }
    }
        public class ApuestaDto3
        {
            public ApuestaDto3(double tipoMercado, string tipo, double cuotaOver, double cuotaUnder, double dinero)
            {
                this.tipoMercado = tipoMercado;
                this.tipo = tipo;
                this.cuotaOver = cuotaOver;
                this.cuotaUnder = cuotaUnder;
                this.dinero = dinero;
            }

            public double tipoMercado { get; set; }

            public string tipo { get; set; }

            public double cuotaOver { get; set; }

            public double cuotaUnder { get; set; }

            public double dinero { get; set; }
        }

}
