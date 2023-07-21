using BCModels.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCNegocio.Service
{
    public interface IProductoService
    {
        Task<bool> Insertar(Producto producto);

        Task<bool> Actualizar(Producto producto);

        Task<bool> Eliminar(int id);

        Task<Producto> Obtener(int id);

        Task<IQueryable<Producto>> MostrarTodos();

        Task<Producto> MostrarPorNombre(string nombre);
    }
}
