using BCDatos.Repositories;
using BCModels.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCNegocio.Service
{
    public class CabezaFacturaService : ICabezaFacturaService
    {
        private readonly IGenericRepository<CabezaFactura> cabezaFactura_repository;

        public CabezaFacturaService(IGenericRepository<CabezaFactura> cabezafac_repository)
        {
            cabezaFactura_repository = cabezafac_repository;
        }

        public async Task<bool> Actualizar(CabezaFactura cabeza_factura)
        {
            return await cabezaFactura_repository.Actualizar(cabeza_factura);

        }

        public async Task<bool> Eliminar(int id)
        {
            return await cabezaFactura_repository.Eliminar(id);
        }

        public async Task<bool> Insertar(CabezaFactura cabeza_factura)
        {
            return await cabezaFactura_repository.Insertar(cabeza_factura);

        }

        public async Task<CabezaFactura> MostrarPorNombre(DateTime fecha)
        {
            IQueryable<CabezaFactura> querycabezafactura = await cabezaFactura_repository.MostrarTodos();
            CabezaFactura cabezafactura = querycabezafactura.Where(x => x.Fecha == fecha).FirstOrDefault();
            return cabezafactura;
        }

        public async Task<IQueryable<CabezaFactura>> MostrarTodos()
        {
            return await cabezaFactura_repository.MostrarTodos();
        }

        public async Task<CabezaFactura> Obtener(int id)
        {
            return await cabezaFactura_repository.Obtener(id);
        }
    }
}
