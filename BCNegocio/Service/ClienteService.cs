using BCDatos.DataContext;
using BCDatos.Repositories;
using BCModels.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCNegocio.Service
{
    public class ClienteService : IClienteService
    {
        private readonly KACTUSContext _context;
        private readonly IGenericRepository<Cliente> cliente_Repository;

        public ClienteService(IGenericRepository<Cliente> cliente_repository )
        {
            this.cliente_Repository = cliente_repository;

        }
        public async Task<bool> Actualizar(Cliente cliente)
        {
            return await cliente_Repository.Actualizar(cliente);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await cliente_Repository.Eliminar(id);
        }

        public async Task<bool> Insertar(Cliente cliente)
        {
           return await cliente_Repository.Insertar(cliente);
        }

        public async Task<Cliente> MostrarPorNombre(string nombre)
        {
            IQueryable<Cliente> querycliente = await cliente_Repository.MostrarTodos();
            Cliente cliente =  querycliente.Where(x => x.NombreCliente ==nombre).FirstOrDefault();
            return cliente;
        }

        public async Task<IQueryable<Cliente>> MostrarTodos()
        {
            return await cliente_Repository.MostrarTodos();
        }

        public async Task<Cliente> Obtener(int id)
        {
            return await cliente_Repository.Obtener(id);

        }
    }
}
