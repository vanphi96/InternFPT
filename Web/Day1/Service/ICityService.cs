using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public interface ICityService
    {
        int Create(city city);
        bool Delete(int id);
        List<city> GetAll();
        city GetByID(int id);
        bool Update(city city);
    }
}
