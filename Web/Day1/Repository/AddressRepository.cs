using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    
   public class AddressRepository : IAddressRepository
    {
        private sakilaDB contex = new sakilaDB();
        public int Create(address address)
        {
            contex.addresses.Add(address);
            contex.SaveChanges();
            return address.address_id;
        }
        public bool Delete(int id)
        {
            var delete = GetByID(id);
            if (delete != null)
            {
                contex.addresses.Remove(delete);
                return contex.SaveChanges() > 0;
            }
            return false;
        }
        public address GetByID(int id)
        {
            return contex.addresses.FirstOrDefault(x => x.address_id == id);
        }
        public bool Update(address address)
        {
            var current = GetByID(address.address_id);
            if (current != null)
            {
                current.address1 = address.address1;
                current.address2 = address.address2;
                current.city = address.city;
                current.city_id = address.city_id;
                current.customers = address.customers;
                return contex.SaveChanges() > 0;
            }
            return false;
        }
        public List<address> GetAll()
        {
            return contex.addresses.ToList();
        }
    }
}
