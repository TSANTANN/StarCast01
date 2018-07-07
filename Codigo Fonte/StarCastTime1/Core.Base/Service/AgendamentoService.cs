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
    public class AgendamentoService : IAgendamentoService
    {

        IRepository<Agendamento> _agendamentoRepository;
        public AgendamentoService(IRepository<Agendamento> entidadeRepository)
        {
            _agendamentoRepository = entidadeRepository;
        }
        public bool Add(Agendamento entidade)
        {
            if (entidade.IsValid)
                return _agendamentoRepository.Insert(entidade);

            return false;
        }

        public bool Delete(int id)
        {
            var entidade = Get(id);
            return _agendamentoRepository.Delete(entidade);
        }

        public Agendamento Get(int Id)
        {
            return _agendamentoRepository.GetAll()
                                     .Where(x => x.Id == Id).FirstOrDefault();
        }

        public IList<Agendamento> GetAll()
        {
            return _agendamentoRepository.GetAll().ToList();
        }


        public bool Update(Agendamento entidade)
        {
            if (entidade.IsValid)
            {
                Get(entidade.Id).Update(entidade);

                return _agendamentoRepository.SaveChanges();
            }

            return false;
        }
    }
}