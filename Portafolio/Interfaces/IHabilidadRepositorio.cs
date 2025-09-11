using Portafolio.Models;

namespace Portafolio.Interfaces
{
    public interface IHabilidadRepositorio
    {
        IEnumerable<HabilidadesModel> ObtenerHabilidades();
    }
}
