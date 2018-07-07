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
    public class EspecialidadeService : IEspecialidadeService
    {
        IRepository<Especialidade> _EspecialidadeRepository;
        public EspecialidadeService(IRepository<Especialidade> entidadeRepository)
        {
            _EspecialidadeRepository = entidadeRepository;
        }
        public bool Add(Especialidade entidade)
        {
            if (entidade.IsValid)
                return _EspecialidadeRepository.Insert(entidade);

            return false;
        }

        public bool Delete(int id)
        {
            var entidade = Get(id);
            return _EspecialidadeRepository.Delete(entidade);
        }

        public Especialidade Get(int Id)
        {
            return _EspecialidadeRepository.GetAll()
                                     .Where(x => x.Id == Id).FirstOrDefault();
        }

        public IList<Especialidade> GetAll()
        {
            return _EspecialidadeRepository.GetAll().ToList();
        }


        public bool Update(Especialidade entidade)
        {
            if (entidade.IsValid)
            {
                Get(entidade.Id).Update(entidade);

                return _EspecialidadeRepository.SaveChanges();
            }

            return false;
        }
    }
}