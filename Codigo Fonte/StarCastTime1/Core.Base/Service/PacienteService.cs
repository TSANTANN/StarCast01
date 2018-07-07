using Core.Base.Entities;
using Core.Base.Interfaces.Repository;
using Core.Base.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base.Service
{
    public class PacienteService : IPacienteService
    {
        IRepository<Paciente> _PacienteRepository;
        public PacienteService(IRepository<Paciente> entidadeRepository)
        {
            _PacienteRepository = entidadeRepository;
        }
        public bool Add(Paciente entidade)
        {
            if (entidade.IsValid)
                return _PacienteRepository.Insert(entidade);

            return false;
        }

        public bool Delete(int id)
        {
            var entidade = Get(id);
            return _PacienteRepository.Delete(entidade);
        }

        public Paciente Get(int Id)
        {
            return _PacienteRepository.GetAll()
                                     .Where(x => x.Id == Id).FirstOrDefault();
        }

        public IList<Paciente> GetAll()
        {
            return _PacienteRepository.GetAll().ToList();
        }


        public bool Update(Paciente entidade)
        {
            if (entidade.IsValid)
            {
                Get(entidade.Id).Update(entidade);

                return _PacienteRepository.SaveChanges();
            }

            return false;
        }
    }
}