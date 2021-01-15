namespace PlaceMyBet.Models
{
    public class MercadoDto
    {
        public double mercado;
        public double cuotaOver;
        public double cuotaUnder;

        public MercadoDto(double mercado, double cuotaOver, double cuotaUnder)
        {
            this.mercado = mercado;
            this.cuotaOver = cuotaOver;
            this.cuotaUnder = cuotaUnder;
        }
    }
}