using TreasureHunt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// namespace CoderCamps.Infrastructure
namespace TreasureHunt.Infrastructure
{
    public class GenericRepository<T> : IDisposable where T : class
    {
        protected ApplicationDbContext _db;

        public GenericRepository(ApplicationDbContext db)
        {
            this._db = db;
        }

        public IQueryable<T> List()
        {
            return _db.Set<T>();
        }

        public void Add(T entity)
        {
            _db.Set<T>().Add(entity);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
            // throw new NotImplementedException();
        }
    }
}
