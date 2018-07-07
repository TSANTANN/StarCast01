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
    public class ConsultaService : IConsultaService
    {
        IRepository<Consulta> _ConsultaRepository;
        public ConsultaService(IRepository<Consulta> entidadeRepository)
        {
            _ConsultaRepository = entidadeRepository;
        }
        public bool Add(Consulta entidade)
        {
            if (entidade.IsValid)
                return _ConsultaRepository.Insert(entidade);

            return false;
        }

        public bool Delete(int id)
        {
            var entidade = Get(id);
            return _ConsultaRepository.Delete(entidade);
        }

        public Consulta Get(int Id)
        {
            return _ConsultaRepository.GetAll()
                                     .Where(x => x.Id == Id).FirstOrDefault();
        }

        public IList<Consulta> GetAll()
        {
            return _ConsultaRepository.GetAll().ToList();
        }


        public bool Update(Consulta entidade)
        {
            if (entidade.IsValid)
            {
                Get(entidade.Id).Update(entidade);

                return _ConsultaRepository.SaveChanges();
            }

            return false;
        }
    }
}