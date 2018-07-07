using Core.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base.Interfaces.Services
{
    public interface IEspecialidadeService
    {
        IList<Especialidade> GetAll();
        bool Add(Especialidade entidade);
        bool Update(Especialidade entidade);
        bool Delete(int id);
        Especialidade Get(int Id);
    }
}
