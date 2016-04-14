using Microsoft.Practices.Unity;
using System.Web.Http;
using AngularJS.Entity.Domain;
using AngularJS.Entity.RepositoryService.DataFactory.Concrete.Repositories;
using AngularJS.Entity.RepositoryService.DataFactory.Interfaces.Repositories;
using AngularJS.Entity.RepositoryService.DataFactory.UnitOfWork;
using Unity.WebApi;

namespace AngularJS.Entity.Service.WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IRepository<Employee>, Repository<Employee>>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}