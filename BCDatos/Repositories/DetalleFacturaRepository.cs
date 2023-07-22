using BCDatos.DataContext;
using BCModels.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDatos.Repositories
{
    public class DetalleFacturaRepository : IGenericRepository<DetalleFactura>
    {
        private readonly KACTUSContext _context;

        public DetalleFacturaRepository(KACTUSContext context)
        {
            _context = context;
        }
        public async Task<bool> Actualizar(DetalleFactura modelo)
        {
            _context.DetalleFacturas.Update(modelo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            DetalleFactura detalleFactura = _context.DetalleFacturas.First(x => x.IddetalleFactura == id);
            _context.DetalleFacturas.Remove(detalleFactura);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(DetalleFactura modelo)
        {
            _context.DetalleFacturas.Add(modelo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IQueryable<DetalleFactura>> MostrarTodos()
        {
            IQueryable<DetalleFactura> querydetallefactura = _context.DetalleFacturas;
            return querydetallefactura;

        }

        public async Task<DetalleFactura> Obtener(int id)
        {
            return await _context.DetalleFacturas.FindAsync(id);
        }
    }
}
