using Portafolio.Interfaces;
using Portafolio.Models;

namespace Portafolio.Repositorios
{
    public class FormacionAcademicaRepositorio : IFormacionAcademicaRepositorio
    {
        public IEnumerable<FormacionAcademicaModel> ObtenerFormacionAcademica()
        {
            return
            [
                new FormacionAcademicaModel
                {
                    Titulo = "Bachiller",
                    Institucion = "Colegio Padre Faustino Miguez.",
                    Year = "2004"
                },
                new FormacionAcademicaModel
                {
                    Titulo = "Ingeniera en Computación.",
                    Institucion = "Universidad Nacional de Ingenieria (UNI).",
                    Year = "2011"
                },
                new FormacionAcademicaModel
                {
                    Titulo = "Excel Avanzado.",
                    Institucion = "Instituto Nicaragüense de Computación (INC).",
                    Year = "2015"
                },
                new FormacionAcademicaModel
                {
                    Titulo = "Desarrollo de Aplicaciones en C# con SQL Server.",
                    Institucion = "Universidad Nacional de Ingenieria (UNI).",
                    Year = "2021"
                },
                new FormacionAcademicaModel
                {
                    Titulo = "Programación Web con ASP.NET CORE 7.0 MVC.",
                    Institucion = "Universidad Nacional de Ingenieria (UNI).",
                    Year = "2024"
                },
                new FormacionAcademicaModel
                {
                    Titulo = "SQL de cero: Tu guía práctica con PostgreSQL.",
                    Institucion = "{dev/talles}",
                    Year = "2024",
                    Instructor = "Fernando Herrera"
                },
                new FormacionAcademicaModel
                {
                    Titulo = "JavaScript Moderno: guía para dominar el lenguaje.",
                    Institucion = "Udemy",
                    Year = "2025",
                    Instructor = "Fernando Herrera"
                },
                new FormacionAcademicaModel
                {
                    Titulo = "Aprende ASP.NET Core MVC 9 Haciendo Proyectos Desde Cero",
                    Institucion = "Udemy",
                    Year = "2025",
                    Instructor = "Felipe Gavilán"
                }
            ];
        }
    }
}
