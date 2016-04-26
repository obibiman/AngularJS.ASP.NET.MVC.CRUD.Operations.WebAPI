using System;
using AngularJS.Entity.RepositoryService.DataFactory.Interfaces.Repositories;

namespace AngularJS.Entity.RepositoryService.DataFactory.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
        ICountryRepository CountryRepository { get; }
        IStateRepository StateRepository { get; }
        int Complete();
    }
}