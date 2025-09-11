using Microsoft.AspNetCore.Mvc;
using Portafolio.Interfaces;
using Portafolio.Models;

namespace Portafolio.Controllers
{
    public class ProyectoController : Controller
    {
        private readonly ILogger<ProyectoController> _logger;
        private readonly IProyectoRepositorio _proyectoRepositorio;

        public ProyectoController(ILogger<ProyectoController> logger, IProyectoRepositorio proyectoRepositorio)
        {
            _logger = logger;
            _proyectoRepositorio = proyectoRepositorio;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<ProyectoViewModel> proyectos = [.. _proyectoRepositorio.ObtenerProyectos()];
            return View(proyectos);
        }
    }
}
