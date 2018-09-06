using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ICountryService
    {
        int Create(country country);
        bool Delete(int id);
        country GetByID(int id);
        bool Update(country country);
        List<country> GetAll();
      
    }
}
