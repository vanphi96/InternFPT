using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IStoreService
    {
        int Create(store store);
        bool Delete(int id);
        List<store> GetAll();
        store GetByID(int id);
        bool Update(store store);
        
    }
}
