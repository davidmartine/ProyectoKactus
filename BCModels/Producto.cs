using System;
using System.Collections.Generic;

namespace BCModels.DataContext
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }

        public int Idproducto { get; set; }
        public string? NombreProducto { get; set; }
        public decimal? Valor { get; set; }

        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}
