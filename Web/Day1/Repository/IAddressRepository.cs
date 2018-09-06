using System.Collections.Generic;
using Model;

namespace Repository
{
    public interface IAddressRepository
    {
        int Create(address address);
        bool Delete(int id);
        List<address> GetAll();
        address GetByID(int id);
        bool Update(address address);
    }
}