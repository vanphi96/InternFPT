using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class StoreRepository : IStoreRepository
    {
        private sakilaDB contex = new sakilaDB();
        public int Create(store store)
        {
            contex.stores.Add(store);
            contex.SaveChanges();
            return store.store_id;
        }
        public bool Delete(int id)
        {
            var delete = GetByID(id);
            if (delete != null)
            {
                contex.stores.Remove(delete);
                return contex.SaveChanges() > 0;
            }
            return false;
        }
        public store GetByID(int id)
        {
            return contex.stores.FirstOrDefault(x => x.store_id == id);
        }
        public bool Update(store store)
        {
            var current = GetByID(store.store_id);
            if (current != null)
            {
                current.address = store.address;
                current.address_id = store.address_id;
                current.customers = store.customers;
                current.inventories = store.inventories;
                current.last_update = store.last_update;
                current.manager_staff_id = store.manager_staff_id;
                current.staff = store.staff;
                current.staffs = store.staffs;
                return contex.SaveChanges() > 0;
            }
            return false;
        }
        public List<store> GetAll()
        {
            return contex.stores.ToList();
        }
    }
}
