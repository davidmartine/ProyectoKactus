using BCModels.DataContext;
using BCNegocio.Service;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProductoService _productoService;


        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            IQueryable<Producto> queryproducto = await _productoService.MostrarTodos();
            List<VMProducto> lista = queryproducto
                                    .Select(x => new VMProducto()
                                    {
                                        Idproducto = x.Idproducto,
                                        NombreProducto = x.NombreProducto,
                                        Valor = x.Valor
                                    }).ToList();
            return StatusCode(StatusCodes.Status200OK, lista);


        }

        [HttpPost]
        public async Task<IActionResult> Insertar([FromBody] VMProducto producto)
        {
            Producto newproducto = new Producto()
            {
                NombreProducto = producto.NombreProducto,
                Valor = producto.Valor
            };

            bool respuesta = await _productoService.Insertar(newproducto);

            return StatusCode(StatusCodes.Status200OK, new { valor = respuesta });
        }

        [HttpPut]
        public async Task<IActionResult> Actualizar([FromBody] VMProducto producto)
        {
            Producto newproducto = new Producto()
            {
                Idproducto = producto.Idproducto,
                NombreProducto = producto.NombreProducto,
                Valor = producto.Valor
            };

            bool respuesta = await _productoService.Actualizar(newproducto);

            return StatusCode(StatusCodes.Status200OK, new {valor = respuesta});
        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar(int id)
        {
            bool respuesta = await _productoService.Eliminar(id);

            return StatusCode(StatusCodes.Status200OK, new {valor = respuesta});
        }
    }
}
