using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private countDayEntities _db { get; set; }
        private DbSet<T> _table = null;

        public GenericRepository()
        {
            _db = new countDayEntities();
            _table = _db.Set<T>();
        }

        public IEnumerable<T> SelectAll()
        {
            return _table.AsEnumerable();
        }

        public async Task<T> Get(object id)
        {
            try
            {
                return _table.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public async Task Insert(T obj)
        {
            _table.Add(obj);
           await _db.SaveChangesAsync();
        }
        public async Task Update(T obj)
        {
            _table.Attach(obj);
            _db.Entry(obj).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }

        public async Task Delete(object id)
        {
            T existing = _table.Find(id);
            _table.Remove(existing);
            await _db.SaveChangesAsync();
        }

    }
}
