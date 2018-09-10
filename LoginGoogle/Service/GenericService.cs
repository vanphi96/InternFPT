using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private IGenericRepository<T> genericRepository = new GenericRepository<T>();
        public void Delete(object id)
        {
            genericRepository.Delete(id);
        }

        public void Insert(T obj)
        {
            genericRepository.Insert(obj);
        }

        public void Save()
        {
            genericRepository.Save();
        }

        public IEnumerable<T> SelectAll()
        {
           return genericRepository.SelectAll();
        }

        public T SelectById(object id)
        {
            return genericRepository.SelectById(id);
        }

        public void Update(T obj)
        {
            genericRepository.Update(obj);
        }
    }
}
