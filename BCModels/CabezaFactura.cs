using System;
using System.Collections.Generic;

namespace BCModels.DataContext
{
    public partial class CabezaFactura
    {
        public CabezaFactura()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }

        public int IdnumeroFac { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Idcliente { get; set; }
        public decimal? Total { get; set; }

        public virtual Cliente? IdclienteNavigation { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}
