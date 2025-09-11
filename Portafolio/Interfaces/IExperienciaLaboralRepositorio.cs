using Portafolio.Models;

namespace Portafolio.Interfaces
{
    public interface IExperienciaLaboralRepositorio
    {
        IEnumerable<ExperienciaLaboralModel> ObtenerExperienciasLaborales();
    }
}
