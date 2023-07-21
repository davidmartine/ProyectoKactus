using BCDatos.Repositories;
using BCModels.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCNegocio.Service
{
    public class ProductoService : IProductoService
    {
        private readonly IGenericRepository<Producto> producto_Repository;

        public ProductoService(IGenericRepository<Producto> producto_repository)
        {
            this.producto_Repository = producto_repository;
        }

        public async Task<bool> Actualizar(Producto producto)
        {
            return await producto_Repository.Actualizar(producto);

        }

        public async Task<bool> Eliminar(int id)
        {
            return await producto_Repository.Eliminar(id);
        }

        public async Task<bool> Insertar(Producto producto)
        {
            return await producto_Repository.Insertar(producto);
        }

        public async Task<Producto> MostrarPorNombre(string nombre)
        {
            IQueryable<Producto> queryproductos = await producto_Repository.MostrarTodos();
            Producto producto = queryproductos.Where(x => x.NombreProducto == nombre).FirstOrDefault();
            return producto;
        }

        public async Task<IQueryable<Producto>> MostrarTodos()
        {
            return await producto_Repository.MostrarTodos();
        }

        public async Task<Producto> Obtener(int id)
        {
            return await producto_Repository.Obtener(id);
        }
    }
}
