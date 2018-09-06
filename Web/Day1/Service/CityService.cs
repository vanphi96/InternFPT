using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class CityService : ICityService
    {
        private ICityRepository cityRepository = new CityRepository();
        public int Create(city city)
        {
            return cityRepository.Create(city);
        }

        public bool Delete(int id)
        {
            return cityRepository.Delete(id);
        }

        public List<city> GetAll()
        {
            return cityRepository.GetAll();
        }

        public city GetByID(int id)
        {
            return cityRepository.GetByID(id);
        }

        public bool Update(city city)
        {
            return cityRepository.Update(city);
        }
    }
}
