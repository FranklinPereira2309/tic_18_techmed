using TechMed.Core.Entities;

namespace TechMed.Application.InputModels
{
    public class NewAtendimentoInputModel
    {
        public int AtendimentoId {get; set;}
        public int MedicoId {get; set;}
        public Medico Medico {get; set;}
        public int PacienteId {get; set;}
        public Paciente Paciente {get; set;}
    }
}
