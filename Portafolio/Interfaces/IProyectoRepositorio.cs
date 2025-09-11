using Portafolio.Models;

namespace Portafolio.Interfaces
{
    public interface IProyectoRepositorio
    {
        IEnumerable<ProyectoViewModel> ObtenerProyectos();
    }
}
