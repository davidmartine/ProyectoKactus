using BCModels.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCNegocio.Service
{
    public interface IDetalleFacturaService
    {
        Task<bool> Insertar(DetalleFactura detalle);

        Task<bool> Actualizar(DetalleFactura detalle);

        Task<bool> Eliminar(int id);

        Task<DetalleFactura> Obtener(int id);

        Task<IQueryable<DetalleFactura>> MostrarTodos();

        //Task<DetalleFactura> MostrarPorValor(decimal valor);
    }
}
