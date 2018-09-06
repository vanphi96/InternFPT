using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class StoreService : IStoreService
    {
        public IStoreRepository storeRepository = new StoreRepository(); 
        public int Create(store store)
        {
            return storeRepository.Create(store);
        }

        public bool Delete(int id)
        {
            return storeRepository.Delete(id);
        }

        public List<store> GetAll()
        {
            return storeRepository.GetAll();
        }

        public store GetByID(int id)
        {
            return storeRepository.GetByID(id);
        }

        public bool Update(store store)
        {
            return storeRepository.Update(store);
        }
    }
}
