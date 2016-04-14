using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using AngularJS.Entity.DataMart.DataContext;
using AngularJS.Entity.Domain;
using AngularJS.Entity.RepositoryService.DataFactory.Interfaces.Repositories;

namespace AngularJS.Entity.RepositoryService.DataFactory.Concrete.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        protected AngularContext _context;

        public EmployeeRepository(AngularContext context) : base(context)
        {
            _context = context;
        }

        public AngularContext AngularContext => _context as AngularContext;

        public Employee Get(Expression<Func<Employee, bool>> predicate)
        {
            return _context.Set<Employee>().SingleOrDefault(predicate);
        }

        public Employee GetById(int Id)
        {
            return _context.Set<Employee>().Find(Id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Set<Employee>().ToList();
        }

        public IEnumerable<Employee> GetAll(Expression<Func<Employee, bool>> predicate = null)
        {
            return _context.Set<Employee>().Where(predicate);
        }

        public int GetEntityKey(Employee entity)
        {
            return _context.Database.SqlQuery<int>("SELECT NEXT VALUE FOR dbo.CustomerSequence;").FirstOrDefault();
        }

        public virtual void Add(Employee entity)
        {
            _context.Set<Employee>().Add(entity);
        }

        public void Update(Employee entity)
        {
            _context.Set<Employee>().AddOrUpdate(entity);
        }

        public void Delete(Employee entity)
        {
            _context.Set<Employee>().Remove(entity);
        }

        public long Count()
        {
            return _context.Set<Employee>().Count(); ;
        }

        public void AddRange(IEnumerable<Employee> entities)
        {
            _context.Set<Employee>().AddRange(entities);
        }

        public void RemoveRange(IEnumerable<Employee> entities)
        {
            _context.Employees.RemoveRange(entities);
        }
    }
}