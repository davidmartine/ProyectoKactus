using BCDatos.Repositories;
using BCModels.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCNegocio.Service
{
    public class DetalleFacturaService : IDetalleFacturaService
    {
        private readonly IGenericRepository<DetalleFactura> detallefactura_repository;

        public DetalleFacturaService(IGenericRepository<DetalleFactura> detallefac)
        {
            detallefactura_repository = detallefac;
        }
        public async Task<bool> Actualizar(DetalleFactura detalle)
        {
            return await detallefactura_repository.Actualizar(detalle);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await detallefactura_repository.Eliminar(id);
        }

        public async Task<bool> Insertar(DetalleFactura detalle)
        {
           return await detallefactura_repository.Insertar(detalle);
        }

        public async Task<IQueryable<DetalleFactura>> MostrarTodos()
        {
            return await detallefactura_repository.MostrarTodos();
        }

        public async Task<DetalleFactura> Obtener(int id)
        {
            return await detallefactura_repository.Obtener(id);
        }
    }
}
