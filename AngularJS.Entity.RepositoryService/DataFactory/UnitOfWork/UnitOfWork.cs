using AngularJS.Entity.DataMart.DataContext;
using AngularJS.Entity.RepositoryService.DataFactory.Concrete.Repositories;
using AngularJS.Entity.RepositoryService.DataFactory.Interfaces.Repositories;

namespace AngularJS.Entity.RepositoryService.DataFactory.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AngularContext _context;
        public IEmployeeRepository EmployeeRepository { get; }

        public UnitOfWork(AngularContext context)
        {
            _context = context;
            EmployeeRepository = new EmployeeRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}