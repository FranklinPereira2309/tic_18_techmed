using TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;


namespace TechMed.Application.Services;
public class AtendimentoService : IAtendimentoService
{
  private readonly ITechMedContext _context;
  public AtendimentoService(ITechMedContext context)
  {
    _context = context;
  }

  public int Create(NewAtendimentoInputModel atendimennto)
  {
    // return _context.PacienteCollection.Create(new Paciente{
    //   Endereco = paciente.Endereco,
    //   Telefone = paciente.
    //   });

    return _context.AtendimentosCollection.Create(new Atendimento {
      Paciente = atendimennto.Paciente,
      Medico = atendimennto.Medico
    });

  }

  public void Delete(int id)
  {
    _context.AtendimentosCollection.Delete(id);
  }

  public List<AtendimentoViewModel> GetAll()
  {
    var atendimento = _context.AtendimentosCollection.GetAll().Select(m => new AtendimentoViewModel{
      PacienteId = m.PacienteId,
      

    }).ToList();

    return atendimento;

  }

  // public PacienteViewModel? GetByCrm(string crm)
  // {
  //   throw new NotImplementedException();
  // }

  public AtendimentoViewModel? GetById(int id)
  {
    var atendimento = _context.AtendimentosCollection.GetById(id);
    
    if(atendimento is null)
      return null;

    var AtendimentoViewModel = new AtendimentoViewModel{
      AtendimentoId = atendimento.AtendimentoId,
     
    };
    return AtendimentoViewModel;
  }

  public void Update(int id, NewAtendimentoInputModel atendimento)
  {
    _context.AtendimentosCollection.Update(id, new Atendimento{
      Medico = atendimento.Medico,
      Paciente = atendimento.Paciente
    
    });
  }
}
