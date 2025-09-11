namespace Portafolio.Models
{
    public class CurriculumViewModel
    {
        public IEnumerable<FormacionAcademicaModel> FormacionAcademica { get; set; } = new List<FormacionAcademicaModel>();
        public IEnumerable<HabilidadesModel> Habilidades { get; set; } = new List<HabilidadesModel>();
        public IEnumerable<ExperienciaLaboralModel> Experiencias { get; set; } = new List<ExperienciaLaboralModel>();
    }
}
