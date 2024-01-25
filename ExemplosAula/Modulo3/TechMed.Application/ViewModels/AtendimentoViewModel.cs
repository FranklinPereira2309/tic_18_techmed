using TechMed.Core.Entities;

namespace TechMed.Application.ViewModels
{
    public class AtendimentoViewModel
    {
        public int AtendimentoId { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
        
    }
}
