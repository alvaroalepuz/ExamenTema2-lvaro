using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Usuario
    {
        public Usuario()
        {

        }
        public Usuario(string usuarioId, string nombre, string apellido, int edad, double mercado)
        {
            this.usuarioId = usuarioId;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.mercado = mercado;
        }

        public string usuarioId { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int edad { get; set; }

        public double mercado { get; set; }

            public List<Apuesta> apuestas2 { get; set; }

            public CasaApuestas casaApuestas2 { get; set; }
    }
}