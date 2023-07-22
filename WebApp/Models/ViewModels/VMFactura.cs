namespace WebApp.Models.ViewModels
{
    public class VMFactura
    {
        public int IdnumeroFac { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Idcliente { get; set; }
        public decimal? Total { get; set; }

        public int IddetalleFactura { get; set; }
        public int? Idproducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal Valor { get; set; }
    }
}
