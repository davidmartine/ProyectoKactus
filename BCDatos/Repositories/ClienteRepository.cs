using BCDatos.DataContext;
using BCModels.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDatos.Repositories
{
    public class ClienteRepository : IGenericRepository<Cliente>
    {
        private readonly KACTUSContext _context;

        public ClienteRepository(KACTUSContext context)
        {
            this._context = context;
        }

        public async Task<bool> Actualizar(Cliente modelo)
        {
            _context.Clientes.Update(modelo);
            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> Eliminar(int id)
        {
            Cliente cliente = _context.Clientes.First(x => x.Idcliente == id);
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Cliente modelo)
        {
            _context.Clientes.Add(modelo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IQueryable<Cliente>> MostrarTodos()
        {
            IQueryable<Cliente> querycliente = _context.Clientes;
            return querycliente;
        }

        public async Task<Cliente> Obtener(int id)
        {
            return await _context.Clientes.FindAsync(id);

        }
    }
}
