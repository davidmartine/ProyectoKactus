using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDatos.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<bool> Insertar(T modelo);

        Task<bool> Actualizar(T modelo);

        Task<bool> Eliminar(T modelo);

        Task<T> Obtener(int id);

        Task<IQueryable<T>> MostrarTodos();



    }
}
