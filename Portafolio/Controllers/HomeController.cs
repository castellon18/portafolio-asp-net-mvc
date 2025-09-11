using Microsoft.AspNetCore.Mvc;
using Portafolio.Interfaces;
using Portafolio.Models;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProyectoRepositorio _proyectoRepositorio;

        public HomeController(ILogger<HomeController> logger, IProyectoRepositorio proyectoRepositorio)
        {
            _logger = logger;
            _proyectoRepositorio = proyectoRepositorio;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<ProyectoViewModel> proyectos = [.. _proyectoRepositorio.ObtenerProyectos().Take(3)];
            HomeIndexViewModel modelo = new() { Proyectos = proyectos };
            return View(modelo);
        }
    }
}
