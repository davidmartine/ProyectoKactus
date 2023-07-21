using BCDatos.DataContext;
using BCModels.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDatos.Repositories
{
    public class ProductoRepository : IGenericRepository<Producto>
    {
        private readonly KACTUSContext _context;

        public ProductoRepository(KACTUSContext context)
        {
            _context = context;
        }

        public async Task<bool> Actualizar(Producto modelo)
        {
            _context.Productos.Update(modelo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Producto producto = _context.Productos.First(x => x.Idproducto == id);
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Producto modelo)
        {
            _context.Productos.Add(modelo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IQueryable<Producto>> MostrarTodos()
        {
            IQueryable<Producto> queryproducto =  _context.Productos;
            return queryproducto;
        }

        public async Task<Producto> Obtener(int id)
        {
            return await _context.Productos.FindAsync(id);
        }
    }
}
