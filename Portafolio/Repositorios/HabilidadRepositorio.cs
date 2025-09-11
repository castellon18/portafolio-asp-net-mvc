using Portafolio.Interfaces;
using Portafolio.Models;

namespace Portafolio.Repositorios
{
    public class HabilidadRepositorio : IHabilidadRepositorio
    {
        public IEnumerable<HabilidadesModel> ObtenerHabilidades()
        {
            return
            [
                new HabilidadesModel
                {
                    Titulo = "Programación",
                    Habilidades =
                    [
                        new Habilidad { Nombre = "Backend", Lista = ["ASP.NET Core", "Node.js", "Express"] },
                        new Habilidad { Nombre = "Fronted", Lista = ["HTML5", "CSS3", "JavaScript", "TypeScript", "Angular", "Blazor"] },
                        new Habilidad { Nombre = "Bases de Datos", Lista = ["SQL Server", "PostgreSQL"] },
                        new Habilidad { Nombre = "Otras Tecnologías", Lista = ["Office 365", "Git", "GitHub", "Postman"] },
                    ]
                },
                new HabilidadesModel
                {
                    Titulo = "Contabilidad",
                    Habilidades =
                    [
                        new Habilidad { Nombre = "Prácticas contables.", },
                        new Habilidad { Nombre = "Integridad y honestidad.", },
                        new Habilidad { Nombre = "Multitarea.", },
                    ]
                },
                new HabilidadesModel
                {
                    Titulo = "Inventario",
                    Habilidades =
                    [
                        new Habilidad { Nombre = "Conocimiento de logísca y almacén.", },
                        new Habilidad { Nombre = "Organización.", },
                        new Habilidad { Nombre = "Trabajo en equipo.", },
                        new Habilidad { Nombre = "Comunicación Efectiva.", },
                    ]
                },
                new HabilidadesModel
                {
                    Titulo = "Otros",
                    Habilidades =
                    [
                        new Habilidad { Nombre = "Fácil aprendizaje.", },
                        new Habilidad { Nombre = "Autodidacta.", },
                        new Habilidad { Nombre = "Expresivo.", },
                    ]
                }
            ];
        }
    }
}
