using Model;
using System.Collections.Generic;

namespace Repository
{
    public interface ICountryRepository
    {
        int Create(country country);
        bool Delete(int id);
        country GetByID(int id);
        bool Update(country country);
        List<country> GetAll();
    }
}