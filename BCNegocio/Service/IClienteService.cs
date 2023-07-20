using BCModels.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCNegocio.Service
{
    public interface IClienteService
    {
        Task<bool> Insertar(Cliente cliente);

        Task<bool> Actualizar(Cliente cliente);

        Task<bool> Eliminar(int id);

        Task<Cliente> Obtener(int id);

        Task<IQueryable<Cliente>> MostrarTodos();

        Task<Cliente> MostrarPorNombre(string nombre);
    }
}
