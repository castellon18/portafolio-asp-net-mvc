namespace Portafolio.Models
{
    public class HabilidadesModel
    {
        public string Titulo { get; set; } = string.Empty;
        public Habilidad[] Habilidades { get; set; } = [];
    }

    public class Habilidad
    {
        public string Nombre { get; set; } = string.Empty;
        public string[] Lista { get; set; } = [];
    }
}
