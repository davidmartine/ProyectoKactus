using BCModels.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCNegocio.Service
{
    public interface ICabezaFacturaService
    {
        Task<bool> Insertar(CabezaFactura cabeza_factura);

        Task<bool> Actualizar(CabezaFactura cabeza_factura);

        Task<bool> Eliminar(int id);

        Task<CabezaFactura> Obtener(int id);

        Task<IQueryable<CabezaFactura>> MostrarTodos();

        Task<CabezaFactura> MostrarPorNombre(DateTime fecha);
    }
}
