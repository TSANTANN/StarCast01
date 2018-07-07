using Core.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base.Interfaces.Services
{
    public interface IAgendamentoService
    {
        IList<Agendamento> GetAll();
        bool Add(Agendamento entidade);
        bool Update(Agendamento entidade);
        bool Delete(int id);
        Agendamento Get(int Id);
    }
}
