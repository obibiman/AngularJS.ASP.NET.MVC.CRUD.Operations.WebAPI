using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using AngularJS.Entity.DataMart.DataContext;
using AngularJS.Entity.RepositoryService.DataFactory.Interfaces.Repositories;

namespace AngularJS.Entity.RepositoryService.DataFactory.Concrete.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public AngularContext FiscalContext => _context as AngularContext;

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().SingleOrDefault(predicate);
        }

        public T GetById(int Id)
        {
            return _context.Set<T>().Find(Id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            return _context.Set<T>().Where(predicate);
        }

        public int GetEntityKey(T entity)
        {
            return _context.Database.SqlQuery<int>("SELECT NEXT VALUE FOR dbo.CustomerSequence;").FirstOrDefault();
        }

        public virtual void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().AddOrUpdate(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public long Count()
        {
            return _context.Set<T>().Count(); ;
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }
}