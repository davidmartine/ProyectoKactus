using BCDatos.DataContext;
using BCModels.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDatos.Repositories
{
    public class CabezaFacturaRepository : IGenericRepository<CabezaFactura>
    {
        private readonly KACTUSContext _context;

        public CabezaFacturaRepository(KACTUSContext context)
        {
            _context = context;
        }
        public async Task<bool> Actualizar(CabezaFactura modelo)
        {
            _context.CabezaFacturas.Update(modelo);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<bool> Eliminar(int id)
        {
            CabezaFactura cabezaFactura = _context.CabezaFacturas.First(x => x.IdnumeroFac == id);
            _context.CabezaFacturas.Remove(cabezaFactura);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(CabezaFactura modelo)
        {
            _context.CabezaFacturas.Add(modelo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IQueryable<CabezaFactura>> MostrarTodos()
        {
            IQueryable<CabezaFactura> querycliente = _context.CabezaFacturas;
            return querycliente;
        }

        public async Task<CabezaFactura> Obtener(int id)
        {
            return await _context.CabezaFacturas.FindAsync(id);
        }
    }
}
