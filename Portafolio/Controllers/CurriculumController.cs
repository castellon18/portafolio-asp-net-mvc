using Microsoft.AspNetCore.Mvc;
using Portafolio.Interfaces;
using Portafolio.Models;

namespace Portafolio.Controllers
{
    public class CurriculumController : Controller
    {
        private ILogger<CurriculumController> _logger;
        private IFormacionAcademicaRepositorio _formacionAcademica;
        private IHabilidadRepositorio _habilidad;
        private IExperienciaLaboralRepositorio _experiencia;

        public CurriculumController(ILogger<CurriculumController> logger, IFormacionAcademicaRepositorio formacionAcademica, IHabilidadRepositorio habilidad, IExperienciaLaboralRepositorio experiencia)
        {
            _logger = logger;
            _formacionAcademica = formacionAcademica;
            _habilidad = habilidad;
            _experiencia = experiencia;
        }

        public IActionResult Index()
        {
            IEnumerable<FormacionAcademicaModel> formacionAcademica = _formacionAcademica.ObtenerFormacionAcademica();
            IEnumerable<HabilidadesModel> habilidades = _habilidad.ObtenerHabilidades();
            IEnumerable<ExperienciaLaboralModel> experiencias = _experiencia.ObtenerExperienciasLaborales();
            CurriculumViewModel model = new()
            {
                FormacionAcademica = formacionAcademica,
                Habilidades = habilidades,
                Experiencias = experiencias
            };
            return View(model);
        }
    }
}
