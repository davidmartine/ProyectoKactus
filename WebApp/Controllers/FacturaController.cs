using BCNegocio.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class FacturaController : Controller
    {
        private readonly ICabezaFacturaService _facturaService;
        private readonly IDetalleFacturaService _detalleFacturaService;

        public FacturaController(ICabezaFacturaService cabeza, IDetalleFacturaService detalle)
        {
            _facturaService = cabeza;
            _detalleFacturaService = detalle;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
