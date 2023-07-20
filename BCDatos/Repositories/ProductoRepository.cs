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

        public Task<bool> Actualizar(Producto modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insertar(Producto modelo)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Producto>> MostrarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Producto> Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
