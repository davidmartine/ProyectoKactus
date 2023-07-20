using BCModels.DataContext;
using BCNegocio.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly IClienteService _clienteService;

        public HomeController(IClienteService clienteService)
        {
           _clienteService = clienteService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            IQueryable<Cliente> querycliente = await _clienteService.MostrarTodos();

            List<WMCliente> lista = querycliente
                                    .Select(x => new WMCliente()
                                    {
                                        Idcliente = x.Idcliente,
                                        NombreCliente = x.NombreCliente,
                                        Direccion = x.Direccion
                                    }).ToList();

            return StatusCode(StatusCodes.Status200OK, lista);
        }


        [HttpPost]
        public async Task<IActionResult> Insertar([FromBody] WMCliente cliente)
        {
            Cliente newcliente = new Cliente()
            {
                NombreCliente = cliente.NombreCliente,
                Direccion = cliente.Direccion
            };

            bool respuesta = await _clienteService.Insertar(newcliente);

            return StatusCode(StatusCodes.Status200OK, new { valor = respuesta });
        }


        [HttpPut]
        public async Task<IActionResult> Actualizar([FromBody] WMCliente cliente)
        {
            Cliente newCliente = new Cliente
            {
                Idcliente = cliente.Idcliente,
                NombreCliente = cliente.NombreCliente,
                Direccion = cliente.Direccion

            };

            bool repuesta = await _clienteService.Actualizar(newCliente);

            return StatusCode(StatusCodes.Status200OK, new {valor = repuesta });

        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar(int id)
        {
            bool respuesta = await _clienteService.Eliminar(id);

            return StatusCode(StatusCodes.Status200OK, new { valor = respuesta});
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}