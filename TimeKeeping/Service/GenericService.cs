using Model;
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
        private IGenericRepository<T>  genericRepository= new GenericRepository<T>();
        public Task Delete(object id)
        {
           return genericRepository.Delete(id);
        }
        public Task<T> Get(object id)
        {
            return genericRepository.Get(id);
        }

        public Task Insert(T obj)
        {
            return genericRepository.Insert(obj);
        }

        public IEnumerable<T> SelectAll()
        {
            return genericRepository.SelectAll();
        }

        public Task Update(T obj)
        {
            return genericRepository.Update(obj);
        }
    }
}
