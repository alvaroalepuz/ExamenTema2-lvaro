using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class CasaApuestas
    {
        public CasaApuestas(int casaApuestasId, double saldoActual, string nombreBanco, int numtarjeta, string correo)
        {
            this.casaApuestasId = casaApuestasId;
            SaldoActual = saldoActual;
            NombreBanco = nombreBanco;
            Numtarjeta = numtarjeta;
            Correo = correo;
        }

        public int casaApuestasId { get; set; }
        public double SaldoActual { get; set; }
        public string NombreBanco { get; set; }
        public int Numtarjeta { get; set; }
        public string Correo { get; set; }

    }
}