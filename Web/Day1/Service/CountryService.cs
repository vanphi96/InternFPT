using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class CountryService : ICountryService
    {
        private ICountryRepository countryRepository = new CountryRepository();
        public int Create(country country)
        {
           return countryRepository.Create(country);
        }

        public bool Delete(int id)
        {
            return countryRepository.Delete(id);
        }

        public List<country> GetAll()
        {
            return countryRepository.GetAll();
        }

        public country GetByID(int id)
        {
            return countryRepository.GetByID(id);
        }

        public bool Update(country country)
        {
            return countryRepository.Update(country);
        }
    }
}
