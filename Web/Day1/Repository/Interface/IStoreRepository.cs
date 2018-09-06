using System.Collections.Generic;
using Model;

namespace Repository
{
    public interface IStoreRepository
    {
        int Create(store store);
        bool Delete(int id);
        List<store> GetAll();
        store GetByID(int id);
        bool Update(store store);
    }
}