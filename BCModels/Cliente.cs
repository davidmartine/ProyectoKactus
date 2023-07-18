using System;
using System.Collections.Generic;

namespace BCModels.DataContext
{
    public partial class Cliente
    {
        public Cliente()
        {
            CabezaFacturas = new HashSet<CabezaFactura>();
        }

        public int Idcliente { get; set; }
        public string? NombreCliente { get; set; }
        public string? Direccion { get; set; }

        public virtual ICollection<CabezaFactura> CabezaFacturas { get; set; }
    }
}
