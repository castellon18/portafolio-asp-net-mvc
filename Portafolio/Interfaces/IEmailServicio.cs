using Portafolio.Models;

namespace Portafolio.Interfaces
{
    public interface IEmailServicio
    {
        Task<bool> EnviarCorreo(ContactoViewModel contacto);
    }
}
