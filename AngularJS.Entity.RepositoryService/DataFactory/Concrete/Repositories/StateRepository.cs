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
    public class StateRepository : Repository<State>, IStateRepository
    {
        protected AngularContext _context;

        public StateRepository(AngularContext context) : base(context)
        {
            _context = context;
        }

        public AngularContext AngularContext => _context as AngularContext;

        public State Get(Expression<Func<State, bool>> predicate)
        {
            return _context.Set<State>().SingleOrDefault(predicate);
        }

        public State GetById(int Id)
        {
            return _context.Set<State>().Find(Id);
        }

        public IEnumerable<State> GetAll()
        {
            return _context.Set<State>().ToList();
        }

        public IEnumerable<State> GetAll(Expression<Func<State, bool>> predicate = null)
        {
            return _context.Set<State>().Where(predicate);
        }

        public int GetEntityKey(State entity)
        {
            return _context.Database.SqlQuery<int>("SELECT NEXT VALUE FOR dbo.CustomerSequence;").FirstOrDefault();
        }

        public virtual void Add(State entity)
        {
            _context.Set<State>().Add(entity);
        }

        public void Update(State entity)
        {
            _context.Set<State>().AddOrUpdate(entity);
        }

        public void Delete(State entity)
        {
            _context.Set<State>().Remove(entity);
        }

        public long Count()
        {
            return _context.Set<State>().Count(); ;
        }

        public void AddRange(IEnumerable<State> entities)
        {
            _context.Set<State>().AddRange(entities);
        }

        public void RemoveRange(IEnumerable<State> entities)
        {
            _context.States.RemoveRange(entities);
        }
    }
}