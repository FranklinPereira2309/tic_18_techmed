namespace TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
public interface IAtendimentoService
{
      public List<AtendimentoViewModel> GetAll();
      public AtendimentoViewModel? GetById(int id);
      // public PacienteViewModel? GetByEndereco(string endereco);
      public int Create(NewAtendimentoInputModel atendimento);
      public void Update(int id, NewAtendimentoInputModel atendimento);
      public void Delete(int id);
}
