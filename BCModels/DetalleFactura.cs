using System;
using System.Collections.Generic;

namespace BCModels.DataContext
{
    public partial class DetalleFactura
    {
        public int IddetalleFactura { get; set; }
        public int? IdnumeroFac { get; set; }
        public int? Idproducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Valor { get; set; }

        public virtual CabezaFactura? IdnumeroFacNavigation { get; set; }
        public virtual Producto? IdproductoNavigation { get; set; }
    }
}
