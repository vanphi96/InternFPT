using System.Collections.Generic;
using Model;

namespace Repository
{
    public interface ICityRepository
    {
        int Create(city city);
        bool Delete(int id);
        List<city> GetAll();
        city GetByID(int id);
        bool Update(city city);
    }
}