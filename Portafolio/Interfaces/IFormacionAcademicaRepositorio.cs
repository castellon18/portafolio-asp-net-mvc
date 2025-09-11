using Portafolio.Models;

namespace Portafolio.Interfaces
{
    public interface IFormacionAcademicaRepositorio
    {
        IEnumerable<FormacionAcademicaModel> ObtenerFormacionAcademica();
    }
}
