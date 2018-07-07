using Core.Base.Interfaces.Repository;
using Core.Base.Interfaces.Services;
using Core.Base.Service;
using Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace Web.Mvc.App_Start
{
    public class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            container.RegisterType<IMedicoService, MedicoService>();
            container.RegisterType<IPacienteService, PacienteService>();
            container.RegisterType<IAgendamentoService, AgendamentoService>();
            container.RegisterType<IConsultaService, ConsultaService>();
            container.RegisterType<IEspecialidadeService, EspecialidadeService>();
            //DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
   
}