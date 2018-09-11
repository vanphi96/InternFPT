using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CountryRepository : ICountryRepository
    {
        private sakilaEntities contex = new sakilaEntities();
        public int Create(country country)
        {
            contex.countries.Add(country);
            contex.SaveChanges();
            return country.country_id;
        }
        public bool Delete(int id)
        {
            var delete = GetByID(id);
            if (delete != null)
            {
                contex.countries.Remove(delete);
                return contex.SaveChanges() > 0;
            }
            return false;
        }
        public country GetByID(int id)
        {
            return contex.countries.FirstOrDefault(x => x.country_id == id);
        }
        public bool Update(country country)
        {
            var current = GetByID(country.country_id);
            if (current != null)
            {
                current.cities = country.cities;
                current.country1 = country.country1;
                return contex.SaveChanges() > 0;
            }
            return false;
        }
        public List<country> GetAll()
        {
            return contex.countries.ToList();
        }
    }
}
