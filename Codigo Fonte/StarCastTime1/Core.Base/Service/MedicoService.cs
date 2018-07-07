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
    public class MedicoService : IMedicoService
    {
        IRepository<Medico> _MedicoRepository;
        public MedicoService(IRepository<Medico> entidadeRepository)
        {
            _MedicoRepository = entidadeRepository;
        }
        public bool Add(Medico entidade)
        {
            if (entidade.IsValid)
                return _MedicoRepository.Insert(entidade);

            return false;
        }

        public bool Delete(int id)
        {
            var entidade = Get(id);
            return _MedicoRepository.Delete(entidade);
        }

        public Medico Get(int Id)
        {
            return _MedicoRepository.GetAll()
                                     .Where(x => x.Id == Id).FirstOrDefault();
        }

        public IList<Medico> GetAll()
        {
            return _MedicoRepository.GetAll().ToList();
        }


        public bool Update(Medico entidade)
        {
            if (entidade.IsValid)
            {
                Get(entidade.Id).Update(entidade);

                return _MedicoRepository.SaveChanges();
            }

            return false;
        }
    }
}