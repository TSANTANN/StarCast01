using Core.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base.Interfaces.Services
{
    public interface IConsultaService
    {
        IList<Consulta> GetAll();
        bool Add(Consulta entidade);
        bool Update(Consulta entidade);
        bool Delete(int id);
        Consulta Get(int Id);
    }
}
