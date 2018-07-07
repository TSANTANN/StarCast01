using Core.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base.Interfaces.Services
{
    public interface IMedicoService
    {
        IList<Medico> GetAll();
        bool Add(Medico entidade);
        bool Update(Medico entidade);
        bool Delete(int id);
        Medico Get(int Id);
    }
}
