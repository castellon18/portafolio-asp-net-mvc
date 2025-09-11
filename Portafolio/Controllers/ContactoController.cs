using Microsoft.AspNetCore.Mvc;
using Portafolio.Interfaces;
using Portafolio.Models;
using System.Threading.Tasks;

namespace Portafolio.Controllers
{
    public class ContactoController : Controller
    {
        private ILogger<ContactoController> _logger;
        private IEmailServicio _emailServicio;

        public ContactoController(ILogger<ContactoController> logger, IEmailServicio emailServicio)
        {
            _logger = logger;
            _emailServicio = emailServicio;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactoViewModel model)
        {
            // 1. Validar el modelo (datos enviados desde el formulario)
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("El modelo de contacto no es válido. Errores: {ValidationErrors}", string.Join("; ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)));
                // Si el modelo no es válido, regresamos a la vista con los errores
                return View(model);
            }

            try
            {
                // 2. Intentar enviar el correo usando el servicio
                bool correoEnviado = await _emailServicio.EnviarCorreo(model);

                if (correoEnviado)
                {
                    // 3. Éxito: Redirigir a una página de agradecimiento
                    _logger.LogInformation("El correo del contacto {Email} se envió con éxito.", model.Email);
                    // Usar TempData para mostrar un mensaje de éxito en la vista de agradecimiento
                    TempData["Mensaje"] = "¡Tu mensaje ha sido enviado con éxito! Nos pondremos en contacto contigo pronto.";
                    return RedirectToAction(nameof(MensajeAgradecimiento));
                }
                else
                {
                    // 4. Fallo: El servicio indicó que no se pudo enviar el correo
                    // Se agrega un error de modelo para que el usuario sepa que algo salió mal.
                    ModelState.AddModelError(string.Empty, "Hubo un problema al enviar tu mensaje. Por favor, inténtalo de nuevo más tarde.");
                    _logger.LogError("Fallo al enviar el correo del contacto {Email}. Se mostró un mensaje de error al usuario.", model.Email);
                    return View(model); // Vuelve a la vista con el mensaje de error
                }
            }
            catch (Exception ex)
            {
                // 5. Error inesperado en el controlador (poco probable si el servicio maneja bien sus errores)
                _logger.LogError(ex, "Ocurrió un error inesperado en el controlador al procesar el envío de correo para {Email}.", model.Email);
                ModelState.AddModelError(string.Empty, "Ocurrió un error inesperado. Por favor, inténtalo de nuevo más tarde.");
                return View(model); // Vuelve a la vista con el mensaje de error
            }
        }

        public IActionResult MensajeAgradecimiento()
        {
            // Puedes pasar el mensaje desde TempData a la vista
            ViewBag.Mensaje = TempData["Mensaje"] as string;
            return View();
        }
    }
}
