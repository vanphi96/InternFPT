using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class AddressService : IAddressService
    {
        private IAddressRepository addressService = new AddressRepository();
        public int Create(address address)
        {
            return addressService.Create(address);
        }

        public bool Delete(int id)
        {
            return addressService.Delete(id);
        }

        public List<address> GetAll()
        {
            return addressService.GetAll();
        }

        public address GetByID(int id)
        {
            return addressService.GetByID(id);
        }

        public bool Update(address address)
        {
            return addressService.Update(address);
        }
    }
}
