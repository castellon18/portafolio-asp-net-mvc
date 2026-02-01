using Portafolio.Interfaces;
using Portafolio.Models;

namespace Portafolio.Repositorios
{
    public class ProyectoRepositorio : IProyectoRepositorio
    {
        public IEnumerable<ProyectoViewModel> ObtenerProyectos()
        {
            return
            [
                    new ProyectoViewModel
                    {
                        Titulo = "Manejo de Ingresos y Gastos",
                        Descripcion = @"Aplicación elaborada con ASP.NET Core 9 MVC y base de datos SQL Server.
                                        Para el manejo de los ingresos y gastos personales.",
                        ImagenUrl = "/assets/img/manejo-presupuesto.png",
                        Link = "http://dayemi.somee.com/"
                    },
                    new ProyectoViewModel
                    {
                        Titulo = "Portafolio",
                        Descripcion = "Pagina web personal implementada con Angular 19.2.0, poniendo en practica los conocimientos aprendidos.",
                        ImagenUrl = "/assets/img/Portafolio-ASP-NET-MVC.png",
                        Link = "https://github.com/castellon18/portfolio-angular.git"
                    },
                    new ProyectoViewModel
                    {
                        Titulo = "Reddit",
                        Descripcion = "Red Social para compartir en comunidad, elaborada en Angular",
                        ImagenUrl = "/assets/img/Country-App.png",
                        Link = "https://www.reddit.com"
                    },
                    new ProyectoViewModel
                    {
                        Titulo = "Steam",
                        Descripcion = "Tienda para comprar video juegos, elaborada en Angular",
                        ImagenUrl = "/assets/img/App-Store.png",
                        Link = "https://www.store.steampowered.com"
                    }
            ];
        }
    }
}
