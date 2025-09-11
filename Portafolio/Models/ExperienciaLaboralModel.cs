namespace Portafolio.Models
{
    public class ExperienciaLaboralModel
    {
        public string Empresa { get; set; } = string.Empty;
        public string Posicion { get; set; } = string.Empty;
        public string Fechas { get; set; } = string.Empty;
        public string[] Responsabilidades { get; set; } = [];
        public string Localidad { get; set; } = string.Empty;
        public TecnologiaUsada[] Tecnologias { get; set; } = [];
    }

    public class TecnologiaUsada
    {
        public string Nombre { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
    }
}
