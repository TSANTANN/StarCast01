using Core.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base.Interfaces.Services
{
    public interface IPacienteService
    {
        IList<Paciente> GetAll();
        bool Add(Paciente entidade);
        bool Update(Paciente entidade);
        bool Delete(int id);
        Paciente Get(int Id);
    }
}
