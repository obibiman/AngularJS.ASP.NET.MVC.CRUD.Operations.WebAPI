using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AngularJS.Entity.DataMart.DataContext;
using AngularJS.Entity.Domain;
using AngularJS.Entity.RepositoryService.DataFactory.Interfaces.Repositories;

namespace AngularJS.Entity.RepositoryService.DataFactory.Concrete.Repositories
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        protected AngularContext _context;

        public CountryRepository(AngularContext context) : base(context)
        {
            _context = context;
        }

        public AngularContext AngularContext => _context as AngularContext;

        public Country Get(Expression<Func<Country, bool>> predicate)
        {
            return _context.Set<Country>().SingleOrDefault(predicate);
        }

        public Country GetById(int Id)
        {
            return _context.Set<Country>().Find(Id);
        }

        public IEnumerable<Country> GetAll()
        {
            return _context.Set<Country>().ToList();
        }

        public IEnumerable<Country> GetAll(Expression<Func<Country, bool>> predicate = null)
        {
            return _context.Set<Country>().Where(predicate);
        }

        public int GetEntityKey(Country entity)
        {
            return _context.Database.SqlQuery<int>("SELECT NEXT VALUE FOR dbo.CustomerSequence;").FirstOrDefault();
        }

        public virtual void Add(Country entity)
        {
            _context.Set<Country>().Add(entity);
        }

        public void Update(Country entity)
        {
            _context.Set<Country>().AddOrUpdate(entity);
        }

        public void Delete(Country entity)
        {
            _context.Set<Country>().Remove(entity);
        }

        public long Count()
        {
            return _context.Set<Country>().Count(); ;
        }

        public void AddRange(IEnumerable<Country> entities)
        {
            _context.Set<Country>().AddRange(entities);
        }

        public void RemoveRange(IEnumerable<Country> entities)
        {
            _context.Countries.RemoveRange(entities);
        }
    }
}
